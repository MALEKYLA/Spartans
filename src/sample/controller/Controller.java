package sample.controller;

import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.stage.Stage;

public class Controller {

    @FXML
    private ResourceBundle resources;

    @FXML
    private URL location;

    @FXML
    private Button avgStudent;

    @FXML
    private Button raitStudent;

    @FXML
    void initialize() {
        avgStudent.setOnAction(event -> {
            avgStudent.getScene().getWindow();

            FXMLLoader loader = new FXMLLoader();

            loader.setLocation(getClass().getResource("/sample/view/avgStudent.fxml"));

            try {
                loader.load();
            } catch (IOException e) {
                e.printStackTrace();
            }

            Parent root = loader.getRoot();
            Stage stage = new Stage();
            stage.setScene(new Scene(root));
            stage.showAndWait();
        });

        raitStudent.setOnAction(event -> {
            raitStudent.getScene().getWindow();

            FXMLLoader loader = new FXMLLoader();

            loader.setLocation(getClass().getResource("/sample/view/raitStudent.fxml"));

            try {
                loader.load();
            } catch (IOException e) {
                e.printStackTrace();
            }

            Parent root = loader.getRoot();
            Stage stage = new Stage();
            stage.setScene(new Scene(root));
            stage.showAndWait();
        });

    }
}

