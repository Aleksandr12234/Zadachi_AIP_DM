public class Point{
    public int x,y;

    public Point(int x, int y){
        this.x=x;
        this.y=y;
    }

    public void SetCordinats(int x, int y){
        this.x+=x;
        this.y+=y;
    }
}