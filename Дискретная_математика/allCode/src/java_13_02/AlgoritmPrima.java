package java_13_02;

import mainObjects.MyPoint;

import java.util.ArrayList;

public class AlgoritmPrima {
    public static void update(MyPoint[] points, String[] table){
        ArrayList<Integer> uslesPoints=new ArrayList<>();
        uslesPoints.add(0);

        int sum=0;
        while (points.length>uslesPoints.size()){
            int minReb=-1;
            int minZnach=-1;

            for (Integer i : uslesPoints) {
                if (i<0 || i>= points.length)continue;
                for (Integer j : points[i].adjacentPoints) {
                    if(uslesPoints.contains(j))continue;
                    int znach=getElement(table, i, j);
                    if((minZnach==-1 || znach<minZnach) && znach!=0){
                        minReb=j;
                        minZnach=znach;
                    }
                }
            }

            uslesPoints.add(minReb);
            sum+=minZnach;
        }

        System.out.println("Алгоритм прима: "+sum);
    }

    private static int getElement(String[] table, int i, int j){
        //строка i столбец j
        String[] line=table[i].split(" ");
        return Integer.parseInt(line[j]);
    }
}
