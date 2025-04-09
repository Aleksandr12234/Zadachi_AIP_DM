public delegate void Stop();

public class Space{
    Point[] grani=new Point[2];
    public Point point;

    public static event Stop End;

    public Space(int x1, int y1, int x2, int y2){
        var random=new Random();

        grani[0]=new Point(x1, y1);
        grani[1]=new Point(x2, y2);

        int minX=Math.Min(x1, x2);
        int maxX=Math.Max(x1, x2);

        int minY=Math.Min(y1, y2);
        int maxY=Math.Max(y1, y2);
        point=new Point(random.Next(minX, maxX), random.Next(minY, maxY));
    }

    public void Check(){
        int minX=Math.Min(grani[0].x, grani[1].x);
        int maxX=Math.Max(grani[0].x, grani[1].x);

        int minY=Math.Min(grani[0].y, grani[1].y);
        int maxY=Math.Max(grani[0].y, grani[1].y);
        if(point.x<minX || point.x>maxX || point.y<minY || point.y>maxY){
            End=()=>{
                Console.WriteLine("Точка вышла за пределы пространства");
                };
        }
    }

    public static bool Close(){
        if(End==null)return false;
        End();
        return true;
    }
}