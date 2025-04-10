package java_13_02;

import java.util.ArrayList;

public class Most {
    public Integer point1, point2, length;

    public Most(int point1, int point2, int length) {
        this.point1 = Math.min(point1, point2);
        this.point2 = Math.max(point1, point2);
        this.length=length;
    }

    public static boolean check(ArrayList<Most> most, int point1, int point2){
        for (Most i : most) {
            if(Math.min(point1, point2)==i.point1 && Math.max(point1, point2) ==i.point2){
                return true;
            }
        }

        return false;
    }

    public static Most min(ArrayList<Most> most){
        int min=-1;
        int k=-1;
        for (int i = 0; i < most.size(); i++) {
            if(min==-1 || most.get(i).length<min){
                min=most.get(i).length;
                k=i;
            }
        }

        return most.get(k);
    }
}
