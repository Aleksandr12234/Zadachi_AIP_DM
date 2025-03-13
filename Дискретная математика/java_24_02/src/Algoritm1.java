public class Algoritm1 {
    public static void update(Point[] points){
        int a=CountOfGraphs.update(points);

        int countOfBreach=0;

        Point[] point1;
        for (int i = 0; i < points.length; i++) {
            for(int j=0; j<points[i].otherPoints.size(); j++){
                point1=points.clone();

                int zero=points[i].otherPoints.get(j);
                point1[zero].otherPoints.remove((Integer) i);
                point1[i].otherPoints.remove((Integer) zero);

                int b=CountOfGraphs.update(point1);

                point1[zero].otherPoints.add(i);
                point1[i].otherPoints.add(zero);

                if(b>a)countOfBreach++;
            }
        }

        System.out.println("Количество мостов: "+countOfBreach/2);
    }
}
