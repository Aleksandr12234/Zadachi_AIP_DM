import java.io.File;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        String[] s = new String[0];
        try{
            Scanner file=new Scanner(new File("input.txt"));
            StringBuilder line= new StringBuilder();
            while (file.hasNextLine()){
                line.append(file.nextLine()).append("/");
            }
            s=line.substring(0, line.length()-2).split("/");
            file.close();
        }catch (Exception ignored){}

        int n=s.length;

        Point[] points=new Point[n];
        for (int i = 0; i < points.length; i++) {
            points[i]=new Point();
            for (int j = 0; j < s[i].length(); j++) {
                if(s[i].charAt(j)=='1') points[i].otherPoints.add(j+1);
            }
        }

        System.out.println("Алгоритм I (вычленение точек из массива): ");
        Algoritm1.update(points);
        System.out.println("Алгоритм II (присвоение точкам номера): ");
        Algoritm2.update(points);
    }
}