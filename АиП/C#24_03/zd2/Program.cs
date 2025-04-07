internal class Program
{
    private static void Main(string[] args)
    {
        Horse[] horses=new Horse[3];
        Console.Write("Номера лошадей: \n");
        for(int i=0; i<horses.Length; i++){
            horses[i]=new Horse();
            Console.Write((i+1)+" ");
        }
        Console.WriteLine("\n");

        Finish finish=new Finish(500);

        while(true){
            foreach(Horse i in horses)i.move();

            Console.WriteLine();
            
            if(finish.Checked(horses))break;
        }
    }
}