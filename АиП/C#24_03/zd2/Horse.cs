public class Horse{
    public int S;
    
    public void move(){
        var rand=new Random();
        S+=rand.Next(0, 70);
        Console.Write(S+" ");
    }
}