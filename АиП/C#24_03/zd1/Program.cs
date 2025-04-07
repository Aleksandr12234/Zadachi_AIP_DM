internal class Program
{
    private static void Main(string[] args)
    {
        Space space=new Space(0, 0, 500,500);

        while(true){
            Console.WriteLine($"X: {space.point.x}; Y: {space.point.y}");
            if(Space.Close())break;

            var random=new Random();
            space.point.SetCordinats(random.Next(-50, 50), random.Next(-50, 50));

            space.Check();
        }
    }
}