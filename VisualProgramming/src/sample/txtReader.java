package sample;
import java.util.*;
import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.io.File;

class txtReader {
    public txtReader(){

    }
    public static List<String[]> getTxt() throws IOException {
        FileReader input = new FileReader("C:\\Users\\YSK\\Desktop\\brand_values.txt");
        BufferedReader bufRead = new BufferedReader(input);
        String myLine = null;
        String[] array1 = new String[100];
        List<String[]> myList = new ArrayList<String[]>();

        while ( (myLine = bufRead.readLine()) != null)
        {
            array1 = myLine.split(",");
            myList.add(array1);
            // tutarlı bir sonuç elde edildiğinin sağlaması
            String[] array2 = array1[1].split(" ");
            for (int i = 0; i < array2.length; i++)
                if(array1[0].equals(array2[i])){
                    continue;
                }
                else {
                    System.out.println("error");
                    break;
                }
        }
        for (int i = 0; i < myList.size();i++)
        {
            System.out.println(myList.get(i));
        }

        //her satırı listeye ekledik ve return ediyoruz
        //örnek vermek gerekirse
        //mylist[0][0] tarih
        //mylist[0][1] marka
        //mylist[0][1] ülke şeklinde gidiyor
        return myList;
    }
}