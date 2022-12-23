package sample;

public class Bar implements Comparable<Bar> {

    private String name;
    private String category;
    private int value;

    public Bar(String name, String category, int value){

    }
    public String getName(){

        return name;
    }
    public String getCategory(){

        return category;
    }
    public int getValue(){

        return value;
    }
    public int compareTo(Bar other){

        return 0;
    }
}