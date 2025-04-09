package java_10_02;

import mainObjects.MyPoint;

import java.util.ArrayList;
import java.util.Arrays;

public class Algoritm2 {
    public static void update(MyPoint[] points){
        ArrayList<Integer> startArray=new ArrayList<>();
        for(int i=0; i< points.length; i++){
            startArray.add(i);
        }

        int k=0;
        while (!startArray.isEmpty()){
            k++;
            func(startArray, startArray.getFirst(), points);
        }

        System.out.println("(Алгоритм 2) Количество графов: "+k);
    }

    static void func(ArrayList<Integer> startArray, Integer a, MyPoint[] points){
        startArray.remove(a);

        for (int i = 0; i < points[a].adjacentPoints.size(); i++) {
            if(startArray.contains(points[a].adjacentPoints.get(i)))func(startArray, points[a].adjacentPoints.get(i), points);
        }
    }
}
