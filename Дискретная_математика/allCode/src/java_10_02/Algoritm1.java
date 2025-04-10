package java_10_02;

import mainObjects.MyPoint;
import java.util.Arrays;

public class Algoritm1 {
    public static boolean sout=true;

    public static int update(MyPoint[] points){
        if(points.length==0){
            if(sout)System.out.println("Графов нет");
            return 0;
        }

        int[] grafNamberPoint=new int[points.length];
        grafNamberPoint[0]=1;

        for (int i = 1; i < grafNamberPoint.length; i++) {
            if(grafNamberPoint[i]==0)grafNamberPoint[i]= Arrays.stream(grafNamberPoint).max().getAsInt()+1;
            if(grafNamberPoint[i]==1)continue;

            for(Integer j : points[i].adjacentPoints){
                if(grafNamberPoint[j]!=0 && grafNamberPoint[j]<grafNamberPoint[i]){
                    grafNamberPoint[i]=grafNamberPoint[j];
                    i=0;
                }
            }
        }

        if(sout)System.out.println("(Алгоритм 1) Количество графов: "+ Arrays.stream(grafNamberPoint).max().getAsInt());
        return Arrays.stream(grafNamberPoint).max().getAsInt();//для алгоритма крускала
    }
}
