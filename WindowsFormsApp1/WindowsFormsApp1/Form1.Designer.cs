
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.nameField = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupField = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectField = new System.Windows.Forms.TextBox();
            this.addSubject = new System.Windows.Forms.Button();
            this.comboSubjectsField = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.selectedGroup = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.selectedStudent = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.selectedMark = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ratingGrid = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.extraPointsField = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.extraMarksSelect = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.budgetField = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddUser.Location = new System.Drawing.Point(12, 125);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(100, 26);
            this.buttonAddUser.TabIndex = 0;
            this.buttonAddUser.Text = "Додати";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(12, 27);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(100, 21);
            this.nameField.TabIndex = 1;
            this.nameField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupField
            // 
            this.groupField.Location = new System.Drawing.Point(12, 71);
            this.groupField.Name = "groupField";
            this.groupField.Size = new System.Drawing.Size(100, 21);
            this.groupField.TabIndex = 2;
            this.groupField.TextChanged += new System.EventHandler(this.groupField_TextChanged);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(12, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(28, 15);
            this.name.TabIndex = 3;
            this.name.Text = "ПІБ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Група";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(129, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Додати предмет";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // subjectField
            // 
            this.subjectField.Location = new System.Drawing.Point(129, 27);
            this.subjectField.Name = "subjectField";
            this.subjectField.Size = new System.Drawing.Size(119, 21);
            this.subjectField.TabIndex = 6;
            this.subjectField.TextChanged += new System.EventHandler(this.subjectField_TextChanged);
            // 
            // addSubject
            // 
            this.addSubject.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addSubject.Location = new System.Drawing.Point(129, 54);
            this.addSubject.Name = "addSubject";
            this.addSubject.Size = new System.Drawing.Size(119, 26);
            this.addSubject.TabIndex = 7;
            this.addSubject.Text = "Додати предмет";
            this.addSubject.UseVisualStyleBackColor = true;
            this.addSubject.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboSubjectsField
            // 
            this.comboSubjectsField.FormattingEnabled = true;
            this.comboSubjectsField.Location = new System.Drawing.Point(12, 225);
            this.comboSubjectsField.Name = "comboSubjectsField";
            this.comboSubjectsField.Size = new System.Drawing.Size(147, 23);
            this.comboSubjectsField.TabIndex = 8;
            this.comboSubjectsField.SelectedIndexChanged += new System.EventHandler(this.comboSubjectsField_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(275, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(744, 504);
            this.dataGridView1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Виставити оцінки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Обрати предмет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Обрати групу";
            // 
            // selectedGroup
            // 
            this.selectedGroup.FormattingEnabled = true;
            this.selectedGroup.Location = new System.Drawing.Point(12, 269);
            this.selectedGroup.Name = "selectedGroup";
            this.selectedGroup.Size = new System.Drawing.Size(147, 23);
            this.selectedGroup.TabIndex = 13;
            this.selectedGroup.SelectedIndexChanged += new System.EventHandler(this.selectedGroup_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Обрати студента";
            // 
            // selectedStudent
            // 
            this.selectedStudent.FormattingEnabled = true;
            this.selectedStudent.Location = new System.Drawing.Point(12, 313);
            this.selectedStudent.Name = "selectedStudent";
            this.selectedStudent.Size = new System.Drawing.Size(147, 23);
            this.selectedStudent.TabIndex = 15;
            this.selectedStudent.SelectedIndexChanged += new System.EventHandler(this.selectedStudent_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Вибрати оцінку";
            // 
            // selectedMark
            // 
            this.selectedMark.FormattingEnabled = true;
            this.selectedMark.Location = new System.Drawing.Point(12, 357);
            this.selectedMark.Name = "selectedMark";
            this.selectedMark.Size = new System.Drawing.Size(147, 23);
            this.selectedMark.TabIndex = 17;
            this.selectedMark.SelectedIndexChanged += new System.EventHandler(this.selectedMark_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 25);
            this.button1.TabIndex = 18;
            this.button1.Text = "Поставити оцінку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ratingGrid
            // 
            this.ratingGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ratingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ratingGrid.Location = new System.Drawing.Point(1045, 27);
            this.ratingGrid.Name = "ratingGrid";
            this.ratingGrid.RowTemplate.Height = 25;
            this.ratingGrid.Size = new System.Drawing.Size(859, 504);
            this.ratingGrid.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(275, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Оцінки:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1045, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Рейтинг:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(12, 521);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 25);
            this.button2.TabIndex = 24;
            this.button2.Text = "Додати бали";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // extraPointsField
            // 
            this.extraPointsField.FormattingEnabled = true;
            this.extraPointsField.Location = new System.Drawing.Point(12, 442);
            this.extraPointsField.Name = "extraPointsField";
            this.extraPointsField.Size = new System.Drawing.Size(147, 23);
            this.extraPointsField.TabIndex = 23;
            this.extraPointsField.SelectedIndexChanged += new System.EventHandler(this.extraPointsField_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 424);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Дод.бали категорія";
            // 
            // extraMarksSelect
            // 
            this.extraMarksSelect.FormattingEnabled = true;
            this.extraMarksSelect.Location = new System.Drawing.Point(12, 492);
            this.extraMarksSelect.Name = "extraMarksSelect";
            this.extraMarksSelect.Size = new System.Drawing.Size(147, 23);
            this.extraMarksSelect.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 468);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Бал";
            // 
            // budgetField
            // 
            this.budgetField.AutoSize = true;
            this.budgetField.Location = new System.Drawing.Point(12, 100);
            this.budgetField.Name = "budgetField";
            this.budgetField.Size = new System.Drawing.Size(65, 19);
            this.budgetField.TabIndex = 27;
            this.budgetField.Text = "Бюджет";
            this.budgetField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.budgetField.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(275, 546);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 39);
            this.button3.TabIndex = 28;
            this.button3.Text = "Видалити дані студентів";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(426, 546);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 39);
            this.button4.TabIndex = 29;
            this.button4.Text = " Видалити предмети з Бази Даних";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(129, 86);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 26);
            this.button5.TabIndex = 30;
            this.button5.Text = "Видалити предмет";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 597);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.budgetField);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.extraMarksSelect);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.extraPointsField);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ratingGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectedMark);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.selectedStudent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.selectedGroup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboSubjectsField);
            this.Controls.Add(this.addSubject);
            this.Controls.Add(this.subjectField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.groupField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.buttonAddUser);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Система для формування рейтингу студентів спеціальності";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TextBox groupField;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subjectField;
        private System.Windows.Forms.Button addSubject;
        private System.Windows.Forms.ComboBox comboSubjectsField;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox selectedGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox selectedStudent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox selectedMark;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView ratingGrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox extraPointsField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox extraMarksSelect;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox budgetField;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

