package java_13_03;

import mainObjects.MyPoint;

public class Floid {
    public static void update(MyPoint[] points){
        //инициализация
        Integer[][] previos =new Integer[points.length] [points.length];
        Integer[][] next=new Integer[points.length][points.length];

        for (int i = 0; i < previos.length; i++) {
            for (int j = 0; j < previos.length; j++) {
                if (i==j) previos[i][j]=0;
                else if(points[i].adjacentPoints.contains(j)){
                    previos[i][j]=points[i].waySize.get(points[i].adjacentPoints.indexOf(j));
                }else  previos[i][j]=null;
            }
        }
        next=assign(previos, next);


        for(int k=0; k< points.length; k++){
            for (int i = 0; i < next.length; i++) {
                for (int j = 0; j < next.length; j++) {
                    if(previos[i][k]==null || previos[k][j]==null)continue;
                    if(next[i][j]==null || next[i][j]>previos[i][k]+previos[k][j]){
                        next[i][j]=previos[i][k]+previos[k][j];
                    }
                }
            }
            previos=assign(next, previos);
        }

        System.out.println("Алгоритм Флоида:");
        for (Integer[] i : next) {
            for (int j = 0; j < next.length; j++) {
                System.out.print(i[j] + " ");
            }
            System.out.println();
        }
    }

    private static Integer[][] assign(Integer[][] on, Integer[][] to){
        for (int i = 0; i < on.length; i++) {
            System.arraycopy(on[i], 0, to[i], 0, on.length);
        }

        return to;
    }
}
