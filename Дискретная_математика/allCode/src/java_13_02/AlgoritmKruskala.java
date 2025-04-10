package java_13_02;

import java_10_02.Algoritm1;
import mainObjects.MyPoint;

import java.util.ArrayList;

public class AlgoritmKruskala {
    public static void update(MyPoint[] points, String[] table){
        Algoritm1.sout=false;
        ArrayList<Most> mosts=new ArrayList<>();
        MyPoint[] newGraph=new MyPoint[points.length];

        for (int i = 0; i < points.length; i++) {
            for(Integer j : points[i].adjacentPoints){
                if(!Most.check(mosts, i, j))
                    mosts.add(new Most(i, j, getElement(table, i, j)));
            }

            newGraph[i]=new MyPoint();
        }


        int sum=0;

        while (!mosts.isEmpty()) {
            int zero = Algoritm1.update(newGraph);
            Most minMost = Most.min(mosts);
            newGraph[minMost.point1].adjacentPoints.add(minMost.point2);
            newGraph[minMost.point2].adjacentPoints.add(minMost.point1);
            int two = Algoritm1.update(newGraph);
            if (zero == two) {
                newGraph[minMost.point1].adjacentPoints.remove(minMost.point2);
                newGraph[minMost.point2].adjacentPoints.remove(minMost.point1);
            } else {
                sum += minMost.length;
            }

            mosts.remove(minMost);
        }

        System.out.println("Алгоритм Краскала: "+sum);
    }

    private static int getElement(String[] table, int i, int j){
        //строка i столбец j
        String[] line=table[i].split(" ");
        return Integer.parseInt(line[j]);
    }
}
