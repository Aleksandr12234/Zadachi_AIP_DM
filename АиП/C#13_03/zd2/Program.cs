internal class Program
{
    private static void Main(string[] args)
    {
        Garages garages=new Garages();
        garages.cars.Add(new Car("a", "b", "c", true));
        garages.cars.Add(new Car("a", "b", "c", false));
        garages.cars.Add(new Car("a", "b", "c", true));
        garages.cars.Add(new Car("a", "b", "c", false));
        garages.cars.Add(new Car("a", "b", "c", true));

        garages.check();

        foreach(Car i in garages.cars){
            Console.WriteLine(i.clean);
        }
    }
}