package mainObjects;

import java_10_02.Algoritm1;
import java_10_02.Algoritm2;
import java_13_02.AlgoritmKruskala;
import java_13_02.AlgoritmPrima;

import java.io.File;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        String[] s=new String[0];
        try{
            Scanner file=new Scanner(new File("input.txt"));
            StringBuilder line=new StringBuilder();
            while (file.hasNextLine()){
                line.append(file.nextLine()).append("/");
            }
            s=line.substring(0, line.length()-1).split("/");
            file.close();
        }catch (Exception ignored){}

        MyPoint[] points = new MyPoint[s.length];
        for (int i = 0; i < points.length; i++) {
            points[i]=new MyPoint();
            String[] list=s[i].split(" ");
            for(int j = 0; j<list.length; j++){
                if(Integer.parseInt(list[j])!=0)
                    points[i].adjacentPoints.add(j);
            }
        }

        alg10_02(points);
        alg13_02(points, s);
    }

    static void alg10_02(MyPoint[] points){
        //связанность (неориентированный граф)
        // 1)Присвоение номера графа
        // 2)Вычеркивание из массива
        Algoritm1.update(points);
        Algoritm2.update(points);
    }

    static void alg13_02(MyPoint[] points, String[] s){
        // 1)Прима
        // 2)Краскала
        AlgoritmPrima.update(points, s);
        AlgoritmKruskala.update(points, s);
    }
}