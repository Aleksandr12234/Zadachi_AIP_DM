import java.util.Arrays;

public class Algoritm2 {
    public static void update(Point[] points){
        int[] numberPoint=new int[points.length];
        numberPoint[0]=1;

        for (int i = 0; i < numberPoint.length; i++) {
            if(numberPoint[i]==0) numberPoint[i] = Arrays.stream(numberPoint).max().getAsInt()+1;

            for (int j = 0; j < points[i].otherPoints.size(); j++) {
                int a= points[i].otherPoints.get(j)-1;
                if(a<i){
                    if(numberPoint[i]>numberPoint[a])numberPoint[i]=numberPoint[a];
                }
            }
            for (int j = 0; j < points[i].otherPoints.size(); j++) {
                int a= points[i].otherPoints.get(j)-1;
                if(a<i){
                    if(numberPoint[i]<numberPoint[a]) {
                        numberPoint[a] = numberPoint[i];
                        i=0;
                    }
                }
            }

        }

        System.out.println("\tОтвет: "+Arrays.stream(numberPoint).max().getAsInt()+" граф(а/ов)");
    }
}
