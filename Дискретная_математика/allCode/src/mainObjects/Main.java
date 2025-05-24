package mainObjects;

import java_10_02.Algoritm1;
import java_10_02.Algoritm2;
import java_10_03.FordBelman;
import java_13_02.AlgoritmKruskala;
import java_13_02.AlgoritmPrima;
import java_13_03.Floid;
import java_24_02.BridgeFinder;
import java_27_02.AlgoritmDeikstra;
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
                if (Integer.parseInt(list[j]) != 0) {
                    points[i].adjacentPoints.add(j);
                    points[i].waySize.add(Integer.parseInt(list[j]));
                }

            }
        }

        /*
        я где-то в алгоритмах меняю points,
        так что все вместе эти функции лучше не запускать,
        а то сломается:D
        */
        alg10_02(points);
        alg13_02(points, s);
        alg27_02(points);
        alg10_03(points);
        alg13_03(points);

        alg24_02(points);//вроде этот изменяет points, так что он будет в конце

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

    static void alg24_02(MyPoint[] points){
        //Поиск мостов
        BridgeFinder.update(points);
    }

    static void alg27_02(MyPoint[] points){
        //поиск минимального пути до всех
        AlgoritmDeikstra.update(points);
    }

    static void alg10_03(MyPoint[] points){
        //форд-Белман
        FordBelman.update(points);
    }

    static void alg13_03(MyPoint[] points){
        //флоид
        Floid.update(points);
    }
}