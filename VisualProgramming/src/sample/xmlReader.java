package sample;
import java.util.*;
import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.io.File;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.ParserConfigurationException;
import org.w3c.dom.Document;
import org.w3c.dom.NodeList;
import org.w3c.dom.Node;
import org.w3c.dom.Element;
import org.xml.sax.SAXException;

class xmlReader {
    public xmlReader() {

    }

    public static List<String[]> getXml() throws ParserConfigurationException, IOException, SAXException {
        File inputFile = new File("C:\\Users\\YSK\\Desktop\\country_populations.xml");
        DocumentBuilderFactory dbfnesne = DocumentBuilderFactory.newInstance();
        DocumentBuilder dbnesne = dbfnesne.newDocumentBuilder();
        Document doc = dbnesne.parse(inputFile);
        doc.getDocumentElement().normalize();
        List<String[]> myListt = new ArrayList<String[]>();
        myListt = (List<String[]>) doc.getElementsByTagName("record");
        List<String[]> myList = new ArrayList<String[]>();
        String[] myarray = new String[((NodeList) myListt).getLength()];

        for (int a = 0; a < ((NodeList) myListt).getLength(); a++) {
            Node _Node = ((NodeList) myListt).item(a);
            if (_Node.getNodeType() == Node.ELEMENT_NODE) {
                Element _Element = (Element) _Node;
                myarray[0] = _Element.getElementsByTagName("name").item(0).getTextContent();
                myarray[1] = _Element.getElementsByTagName("Country").item(0).getTextContent();
                myarray[2] = _Element.getElementsByTagName("Year").item(0).getTextContent();
                myarray[3] = _Element.getElementsByTagName("Value").item(0).getTextContent();
                myarray[4] = _Element.getElementsByTagName("Country").item(0).getTextContent();
                myList.add(myarray);
            } else {
                System.out.println("HATA");
                break;
            }
        }
        return myList;
    }
}