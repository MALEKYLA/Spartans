using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Mysql mysql = new Mysql(); // подключение mysql

        private int currentStudent = 1; // текущий студент 
        private int currentGroup = 0; // текущая группа
        private string emptyString = "[{\""; // пустая строка для вывода предметов из БД

        public List<DataGridModel> DataGrid = new List<DataGridModel>(); // массив с студентов 
        public List<AverageListModel> averageList = new List<AverageListModel>(); // словарь с оценками студентов 
        public Form1()
        {
            InitializeComponent(); // инициализация компонентов 

            LoadSubjectFromDb();
            LoadGroupsFromDb();

            DefaultSettings(); // подгрузить первоначальные настройки кнопок
            UpdateDataGrid(); // обновить данные таблицы
        } 
        private List<DataGridModel> GetData()
        {
            try
            {
                var ratingData = new List<RatingGridModel>();
                var studentsData = new List<DataGridModel>(); // создание массива для данных студентов 
                MySqlCommand command = new MySqlCommand($"SELECT `id`, `name`, `group`, `studentMarks`, `Sport`, `CreativeActivity`, `Captain`, `PublicActivity`, `ScienceActivity`, `budget` FROM students", mysql.GetConnection()); // запрос в БД, чтобы узнать данные пользователей 
                var studentsResult = command.ExecuteReader();
                while (studentsResult.Read()) // пока данные не равны null - записываем их 
                {
                    var jsonData = JsonConvert.DeserializeObject<List<SubjectModel>>(studentsResult[3].ToString()); // десериализация полученных данных
                    if (jsonData != null) // если данные не равны null
                    {
                        var isExsist = averageList.FirstOrDefault(x => x.Id == Convert.ToInt32(studentsResult[0]));
                        Debug.WriteLine($"id: {Convert.ToInt32(studentsResult[0])}");
                        if (isExsist != null) // смотрим, есть ли в словаре уже такой студент
                        {
                            var findIndex = averageList.FindIndex(x => x.Id == Convert.ToInt32(studentsResult[0]));
                            averageList[findIndex].Marks = jsonData;
                        }
                        else
                        {
                            averageList.Add(new AverageListModel { Id = Convert.ToInt32(studentsResult[0]), Marks = jsonData }); // если не существует, добавляем новый список 
                        }
                    }
                    Debug.WriteLine(JsonConvert.SerializeObject(averageList));
                    
                    var result = averageList.Any(x => x.Id == Convert.ToInt32(studentsResult[0])); // ищем в словаре оценки студента по его номеру в БД
                    double mark = 0;
                    int counter = 0;
                    if (result)
                    {
                        var findMarks = averageList.FirstOrDefault(x => x.Id == Convert.ToInt32(studentsResult[0]));
                        var data = JsonConvert.DeserializeObject<List<SubjectModel>>(JsonConvert.SerializeObject(findMarks.Marks));
                        foreach (var marks in data)
                        {
                            mark += marks.Mark;
                            counter++;
                        }
                        mark = Math.Round(mark / counter, 2); // если оценки есть, получаем её среднее число
                    }
                    // добавляем данные в JSON модель
                    studentsData.Add(new DataGridModel { Id = Convert.ToInt32(studentsResult[0]), AverageMark = mark, Name = Convert.ToString(studentsResult[1]), Group = Convert.ToInt32(studentsResult[2]), Subjects = Convert.ToString(studentsResult[3]).Replace(emptyString, "").Replace("}", "").Replace("Subject\":\"", "").Replace("\",\"", ":").Replace("Mark\":", " ").Replace("]", "").Replace("{\"", " ") });
                    if (Convert.ToInt32(studentsResult[9]) == 1)
                    {
                        var percent = Convert.ToInt32(studentsResult[4]) + Convert.ToInt32(studentsResult[5]) + Convert.ToInt32(studentsResult[6]) + Convert.ToInt32(studentsResult[7]) + Convert.ToInt32(studentsResult[8]);
                        if (percent > 10)
                        {
                            percent = 10;
                        }
                        var pecentMark = Math.Round((mark / 100) * percent, 2);
                        var consolidatedMark = Math.Round(pecentMark + mark, 2);



                        ratingData.Add(new RatingGridModel { Id = Convert.ToInt32(studentsResult[0]), AverageMark = mark, Name = Convert.ToString(studentsResult[1]), Group = Convert.ToInt32(studentsResult[2]), Sport = Convert.ToInt32(studentsResult[4]), CreativeActivity = Convert.ToInt32(studentsResult[5]), Captain = Convert.ToInt32(studentsResult[6]), PublicActivity = Convert.ToInt32(studentsResult[7]), ScienceActivity = Convert.ToInt32(studentsResult[8]), Percent = percent, Mark = pecentMark, ConsolidatedMark = consolidatedMark });
                    }
                }

                List<RatingGridModel> sortedStudents = ratingData.OrderBy(x => x.ConsolidatedMark).ToList();
                sortedStudents.Reverse();
                ratingGrid.DataSource = sortedStudents;
                //ratingGrid.Sort(ratingGrid.Columns["ConsolidatedMark"], ListSortDirection.Ascending);

                studentsResult.Close(); // закрываем 
                return studentsData; // возваращаем JSON модель
            }
            catch (Exception e)
            {
                Debug.WriteLine($"[ERR!] Message: {e.Message}\r\nStackTrace:{e.StackTrace}");
                if (e.InnerException != null)
                {
                    Debug.WriteLine($"[ERR!] Message: {e.InnerException.Message}\r\nStackTrace:{e.StackTrace}");
                }
                return null;
            }
            
        }
        private void UpdateDataGrid() 
        {
            DataGrid = GetData();  // получаем JSON модель 
            var data = this.DataGrid; // присваиваем JSON модель
            dataGridView1.DataSource = data; //  отправляем json модель в таблицу

        }
        private void DefaultSettings()
        {
            selectedMark.Enabled = false;
            selectedGroup.Enabled = false;
            selectedStudent.Enabled = false;
            groupField.Enabled = false;
            addSubject.Enabled = false;
            extraMarksSelect.Enabled = false;
            extraPointsField.Enabled = false;
            buttonAddUser.Enabled = false;
            selectedMark.Items.AddRange(new object[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 ,12 });
            extraMarksSelect.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 });
            extraPointsField.Items.AddRange(new object[] { "Спортивна діяльність", "Творча діяльність", "Староста", " Громадська діяльність", "Научная діяльність" });
        }
        private void LoadGroupsFromDb()
        {
            MySqlCommand command = new MySqlCommand($"SELECT `group` FROM `students`", mysql.GetConnection()); // подгружаем группы из БД и добавляем их для выбора в выпадающем списке
            var result = command.ExecuteReader();
            while (result.Read())
            {
                selectedGroup.Items.Remove(result[0].ToString());
                if (!selectedGroup.Items.Contains(result[0].ToString()))
                {
                    selectedGroup.Items.Add(result[0].ToString());
                }

            }
            result.Close();
        }
        private void LoadSubjectFromDb()
        {
            MySqlCommand command = new MySqlCommand($"SELECT `id`, `subject` FROM `subjects`", mysql.GetConnection()); // подгружаем предметы из БД и добавляем их для выбора в выпадающем списке
            var result = command.ExecuteReader();
            if (result != null)
            {
                while (result.Read())
                {
                    comboSubjectsField.Items.Remove(result[1].ToString());
                    comboSubjectsField.Items.Add(result[1].ToString());
                }
            }
            result.Close();

        }
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            String name = nameField.Text; // Получаем данные
            String group = groupField.Text;
            Boolean isBudget = budgetField.Checked;
            Debug.WriteLine($"{isBudget}");
            MySqlCommand command = new MySqlCommand($"INSERT INTO students(`name`, `group`, `budget`) VALUES('{name}', '{group}', '{Convert.ToInt32(isBudget)}')", mysql.GetConnection()); // добавляем юзера
            command.ExecuteNonQueryAsync();
            LoadGroupsFromDb();
            UpdateDataGrid();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            groupField.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            String subject = subjectField.Text;

            MySqlCommand command = new MySqlCommand($"SELECT `subject` FROM `subjects` WHERE `subject` = '{subject}'", mysql.GetConnection()); // делаем запрос, чтобы добавить группу в БД
            var exist = Convert.ToString(await command.ExecuteScalarAsync()); // выполняем запрос
            if (exist != string.Empty)
            {
                MessageBox.Show("Предмет вже є в Базі Даних");
                
            }
            else
            {
                command.CommandText = $"INSERT INTO subjects(subject) VALUES('{subject}')"; // добавляем
                await command.ExecuteNonQueryAsync();
                LoadSubjectFromDb();
                UpdateDataGrid();
            }
            
        }

        private void selectedGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentItem = int.Parse(selectedGroup.SelectedItem.ToString()); // получаем индекс нужной группы
            if (currentGroup != currentItem)
            {
                selectedStudent.Items.Clear();// очищаем список
            }
            MySqlCommand command = new MySqlCommand($"SELECT `name` FROM `students` WHERE `group` = {currentItem}", mysql.GetConnection()); // делаем запрос, выбираем юзера
            var result = command.ExecuteReader(); 
            while (result.Read())
            {
                Debug.WriteLine(result.FieldCount.ToString());
                selectedStudent.Items.Add(result[0].ToString()); // добавляем юзеров в список
            }
            currentGroup = currentItem;
            selectedStudent.Enabled = true;
            result.Close();
        }

        private void comboSubjectsField_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedGroup.Enabled = true;
        }

        private void subjectField_TextChanged(object sender, EventArgs e)
        {
            addSubject.Enabled = true;
        }

        private void groupField_TextChanged(object sender, EventArgs e)
        {
            buttonAddUser.Enabled = true;
        }

        private void selectedMark_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectedStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMark.Enabled = true;
            extraPointsField.Enabled = true;
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            String subject = comboSubjectsField.Text;
            int group = int.Parse(selectedGroup.Text);
            String student = selectedStudent.Text;
            int mark = int.Parse(selectedMark.Text);
            MySqlCommand command = new MySqlCommand($"SELECT `studentMarks` FROM `students` WHERE `name` = '{student}'", mysql.GetConnection()); // выбираем оценки пользователя
            var exist = Convert.ToString(await command.ExecuteScalarAsync()); 
            if (exist.ToString() != string.Empty) // если строка не пустая, выполняем условие
            { 
                var jsonData = JsonConvert.DeserializeObject<List<SubjectModel>>(exist); // десериализуем список оценок
                if (jsonData != null)
                {
                    var findExsistSubjects = jsonData.Any(x => x.Subject == subject); // смотрим, стоит ли оценка по предмету. Если да - изменяем, нет - добавляем
                    var findIndex = jsonData.FindIndex(x => x.Subject == subject);
                    if (findExsistSubjects)
                    {
                        jsonData.RemoveAt(findIndex);
                        MessageBox.Show("Оцінка змінена");
                        
                        jsonData.Add(new SubjectModel { Subject = subject, Mark = mark });
                    }
                    else
                    {
                        jsonData.Add(new SubjectModel { Subject = subject, Mark = mark });
                    }
                }
                else
                {
                    jsonData.Add(new SubjectModel { Subject = subject, Mark = mark });
                }
                command = new MySqlCommand($"UPDATE students SET studentMarks = '{JsonConvert.SerializeObject(jsonData)}' WHERE name = '{student}'", mysql.GetConnection()); // обновляем список оценок
                command.ExecuteNonQuery();
            }
            else
            {
                var list = new List<SubjectModel>();
                list.Add(new SubjectModel { Subject = subject, Mark = mark });
                command = new MySqlCommand($"UPDATE students SET studentMarks = '{JsonConvert.SerializeObject(list)}' WHERE name = '{student}'", mysql.GetConnection()); // обновляем список оценок
                command.ExecuteNonQuery();
            }
            UpdateDataGrid(); // обновляем данные таблицы
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String student = selectedStudent.Text;
            int mark = (int)extraMarksSelect.SelectedItem;
            MySqlCommand command = new MySqlCommand("", mysql.GetConnection());
            switch (extraPointsField.SelectedIndex)
            {
                case 0:
                    command.CommandText = $"UPDATE students SET Sport = {mark} WHERE name = '{student}'";
                    command.ExecuteNonQuery();
                    break;
                case 1:
                    command.CommandText = $"UPDATE students SET CreativeActivity = {mark} WHERE name = '{student}'";
                    command.ExecuteNonQuery();
                    break;
                case 2:
                    command.CommandText = $"UPDATE students SET Captain = {mark} WHERE name = '{student}'";
                    command.ExecuteNonQuery();
                    break;
                case 3:
                    command.CommandText = $"UPDATE students SET PublicActivity = {mark} WHERE name = '{student}'";
                    command.ExecuteNonQuery();
                    break;
                case 4:
                    command.CommandText = $"UPDATE students SET ScienceActivity = {mark} WHERE name = '{student}'";
                    command.ExecuteNonQuery();
                    break;
            }
            UpdateDataGrid();
            MessageBox.Show("Дані внесені");
        }

        private void extraPointsField_SelectedIndexChanged(object sender, EventArgs e)
        {
            extraMarksSelect.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM students", mysql.GetConnection());
            command.ExecuteNonQuery();
            UpdateDataGrid();
            MessageBox.Show("Дані студентів");
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            String subject = subjectField.Text;

            MySqlCommand command = new MySqlCommand($"SELECT `subject` FROM `subjects` WHERE `subject` = '{subject}'", mysql.GetConnection());
            var exist = Convert.ToString(await command.ExecuteScalarAsync()); // выполняем запрос
            if (exist != string.Empty)
            {
                command.CommandText = $"DELETE FROM `subjects` WHERE `subject` = '{subject}'";
                command.ExecuteNonQuery();
                MessageBox.Show("Предмет видалений");
                UpdateDataGrid();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM subjects", mysql.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Предмети видалені");
            LoadSubjectFromDb();
            UpdateDataGrid();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
