import java.util.ArrayList;
import java.util.Arrays;

public class Algoritm1 {
    public static void update(Point[] points, String[] s){
        ArrayList<Integer> ispTochki=new ArrayList<>();
        int sum=0;

        int[][] lines=new int[s.length][];
        for (int i=0; i< lines.length; i++) {
            lines[i]=Arrays.stream(s[i].split(" ")).mapToInt(Integer::parseInt).toArray();
        }

        int i=0;
        while (ispTochki.size()< points.length){
            if(!ispTochki.contains(i))ispTochki.add(i);

            int minValue=0;
            for (int i1 : lines[i]) {
                if(minValue==0 || (i1<minValue && i1>0))minValue=i1;
            }
            sum+=minValue;
            for (int j = points[i].otherPoints.size()-1; j >-1 ; j--) {
                int a=points[i].otherPoints.get(j);
                if(!ispTochki.contains(a) && lines[i][a]==minValue && minValue>0){
                    ispTochki.add(a);
                    lines[i][a]=0;
                    lines[a][i]=0;
                    i=a;
                    break;
                }
            }

            if(minValue==0)i++;
            if (i>=points.length) i=0;
            System.out.print("");
        }

        System.out.println("\tОтвет: "+sum);
    }
}
