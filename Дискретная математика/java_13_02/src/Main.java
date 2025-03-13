import java.io.File;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        //минимальная цена пути
        String[] s = new String[0];
        try{
            Scanner file=new Scanner(new File("input.txt"));
            StringBuilder line= new StringBuilder();
            while (file.hasNextLine()){
                line.append(file.nextLine()).append("/");
            }
            //System.out.println(line.substring(0, line.length()-1));
            s=line.substring(0, line.length()-1).split("/");
            file.close();
        }catch (Exception ignored){}

        int n=s.length;

        Point[] points=new Point[n];
        for (int i = 0; i < points.length; i++) {
            points[i]=new Point();
            String[] list=s[i].split(" ");
            for (int j = 0; j < list.length; j++) {
                if(Integer.parseInt(list[j])>0) points[i].otherPoints.add(j);
            }
        }
        System.out.println("Максимальная цена пути\nАлгоритм 1:");
        Algoritm1.update(points, s);
    }
}