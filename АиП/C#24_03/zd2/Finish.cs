public delegate void End(int i);

public class Finish{
    int S;
    event End TheEnd=Win.update;

    public Finish(int S){this.S=S;}

    public bool Checked(Horse[] horses){
        for(int i=0; i<horses.Length; i++){
            if(horses[i].S>=S) {
                TheEnd(i);
                return true;
            }
        }

        return false;
    }
}

public class Win{
    public static void update(int i){
        Console.WriteLine("Победила лошать под номером "+(i+1));
    }
}