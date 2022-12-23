package sample;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.control.*;
import java.io.IOException;

public class Controller {
    @FXML
    private Button btnText;
    @FXML
    private Button btnXml;
    @FXML
    private Button btnStart;
    @FXML
    private Button btnstop;
    @FXML
    private Button btnReset;
    @FXML
    private CheckBox linechartBox;
    @FXML
    private CheckBox barchartBox;

    @FXML
    public void presstextButton(ActionEvent event) throws IOException {
        System.out.println("TXT Formatını seçtiniz.");
        if(btnText.isFocused()) btnXml.setDisable(true);
        txtReader txtReader = new txtReader();
    }
    @FXML
    public void pressxmlButton(ActionEvent event) {
        System.out.println("XML Formatını seçtiniz..");
        if(btnXml.isFocused()) btnText.setDisable(true);
        xmlReader xmlReader = new xmlReader();
    }
    public void disablebuttons(boolean start,boolean stop){
        btnStart.setDisable(start);
        btnstop.setDisable(stop);
    }
    @FXML
    public void pressstartButton(ActionEvent event) {
        System.out.println("Animasyon Başlatılıyor..");
        disablebuttons(true,false);
    }
    @FXML
    public void pressstopButton(ActionEvent event){
        System.out.println("Animasyon Durduruldu..");
        disablebuttons(false,true);
    }
    @FXML
    public void pressresetButton(ActionEvent event){
        System.out.println("Animasyon Yeniden Başlatılıyor..");
        disablebuttons(false,false);
}
    @FXML
    public void handlechartBox(){
        if (linechartBox.isSelected()){
            barchartBox.setSelected(false);
            System.out.println("Line Chart Animasyon");
        }
        else if(barchartBox.isSelected()) {
            linechartBox.setSelected(false);
            System.out.println("Bar Chart Animasyon");
        }

    }
}
