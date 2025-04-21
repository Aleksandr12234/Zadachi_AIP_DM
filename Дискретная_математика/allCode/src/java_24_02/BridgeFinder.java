package java_24_02;

import java_10_02.Algoritm1;
import mainObjects.MyPoint;

public class BridgeFinder {
    public static void update(MyPoint[] points){
        Algoritm1.sout=false;
        int countOfOriginalGraph=Algoritm1.update(points);

        int countOfBreach=0;

        MyPoint[] point1;
        for (int i = 0; i < points.length; i++) {
            for(int j=0; j<points[i].adjacentPoints.size(); j++){
                point1=points.clone();

                int zero=points[i].adjacentPoints.get(j);
                point1[zero].adjacentPoints.remove((Integer) i);
                point1[i].adjacentPoints.remove((Integer) zero);

                int countOfNewGraph =Algoritm1.update(point1);

                point1[zero].adjacentPoints.add(i);
                point1[i].adjacentPoints.add(zero);

                if(countOfNewGraph > countOfOriginalGraph)countOfBreach++;
            }
        }

        System.out.println("Количество мостов: "+countOfBreach/2);
    }
}
