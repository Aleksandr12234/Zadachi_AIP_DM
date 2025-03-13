import java.util.ArrayList;
import java.util.Arrays;

public class CountOfGraphs {
    public static int update(Point[] points){
        int[] point=new int[points.length];
        for (int i = 0; i < point.length; i++) {
            point[i]=i;
        }
        ArrayList<Point> massive=new ArrayList<>();
        massive.add(new Point());
        massive.getFirst().otherPoints.add(point[0]);
        point[0]=0;

        for(int k=0; k<massive.size(); k++){
            for (int i = 0; i < massive.get(k).otherPoints.size(); i++) {
                for (int j = 0; j < point.length; j++) {
                    if (points[massive.get(k).otherPoints.get(i)].otherPoints.contains(point[j])) {
                        massive.get(k).otherPoints.add(point[j]);
                        point[j] = 0;
                    }
                }
            }
            point= Arrays.stream(point).sorted().toArray();
            if(point[point.length-1]>0){
                massive.add(new Point());
                massive.get(k+1).otherPoints.add(point[point.length-1]);
                point[point.length-1]=0;
            }
        }

        //System.out.println("\tОтвет: "+massive.size()+" граф(а/ов)");
        return massive.size();
    }
}
