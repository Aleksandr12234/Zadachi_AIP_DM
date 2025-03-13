internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите сторону квадрата: ");
        Figuri rect=new Rect(Convert.ToInt32(Console.ReadLine()));
        Console.Write("Введите радиус окружности: ");
        Figuri circle=new Circle(Convert.ToInt32(Console.ReadLine()));
        Console.Write("Введите сторону треугольника: ");
        Figuri rectangle=new Rectangle(Convert.ToInt32(Console.ReadLine()));

        Console.WriteLine("Квадрат (площадь/периметр): "+rect.getS() +"/"+rect.getP());
        Console.WriteLine("Круг (площадь/периметр): "+circle.getS() +"/"+circle.getP());
        Console.WriteLine("Треугольник (площадь/периметр): "+rectangle.getS() +"/"+rectangle.getP());
    }
}