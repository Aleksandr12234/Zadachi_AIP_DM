package java_10_03;

import mainObjects.MyPoint;

public class FordBelman {
    public static void update(MyPoint[] points){
        Integer[][] weightMatrix=new Integer[points.length][points.length];
        weightMatrix[0][0]=0;

        for (int i = 1; i < weightMatrix.length; i++) {
            weightMatrix[i][0]=0;
            for (int j = 1; j < weightMatrix[i].length; j++) {
                for (int k = 0; k < weightMatrix[i-1].length; k++) {
                    if(weightMatrix[i-1][k]==null || searchWay(points, k, j)==null)continue;
                    if(weightMatrix[i][j]==null || weightMatrix[i][j]>weightMatrix[i-1][k]+searchWay(points, k, j)){
                        weightMatrix[i][j]=weightMatrix[i-1][k]+searchWay(points, k, j);
                    }
                }
            }
        }

        System.out.println("Форд-Белман: ");
        for (int i : weightMatrix[weightMatrix.length-1]) {
            System.out.print(i+" ");
        }
        System.out.println();
    }

    private static Integer searchWay(MyPoint[] points, int from, Integer to){
        if(!points[from].adjacentPoints.contains(to))return null;
        return points[from].waySize.get(points[from].adjacentPoints.indexOf(to));
    }
}
