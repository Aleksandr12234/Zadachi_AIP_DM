package java_27_02;

import mainObjects.MyPoint;

import java.util.ArrayList;
import java.util.HashMap;

public class AlgoritmDeikstra {
    public static void update(MyPoint[] points){
        ArrayList<MyPoint> visitedPoints=new ArrayList<>();
        HashMap<MyPoint, Integer> markPoint=new HashMap<>();

        for (MyPoint i : points) {
            markPoint.put(i, null); //null - вместо бесконечности
        }

        MyPoint pointInterest=points[0];
        markPoint.put(pointInterest, 0);//начальная точка

        while (visitedPoints.size()< points.length){
            for (int i = 0; i < pointInterest.adjacentPoints.size(); i++) {
                int numberOfAddPoint=pointInterest.adjacentPoints.get(i);
                if(visitedPoints.contains(points[numberOfAddPoint]))continue;
                if(markPoint.get(points[numberOfAddPoint])==null ||
                        markPoint.get(points[numberOfAddPoint])>pointInterest.waySize.get(i)+ markPoint.get(pointInterest))
                    markPoint.put(
                        points[numberOfAddPoint],
                        pointInterest.waySize.get(i)+ markPoint.get(pointInterest));
            }
            visitedPoints.add(pointInterest);

            MyPoint newPoint=pointInterest;
            Integer minValue=null;
            for (MyPoint i : points) {
                if(visitedPoints.contains(i) || markPoint.get(i)==null)continue;
                if(minValue==null || minValue> markPoint.get(i)){
                    minValue=markPoint.get(i);
                    newPoint=i;
                }
            }

            if(pointInterest==newPoint)break;

            pointInterest=newPoint;
        }

        System.out.print("Алгоритм Дейкстра: ");
        for (MyPoint i : points) {
            System.out.print(markPoint.get(i)+" ");
        }

        System.out.println();
    }
}
