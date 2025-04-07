delegate void Math(float a, float b);

internal class Program
{
    private static void Main(string[] args)
    {
        Math func=(float a, float b)=>{
            Console.WriteLine("Сумма: "+(a+b));
        };
        func+=(float a, float b)=>{
            Console.WriteLine("Разность: "+(a-b));
        };
        func+=(float a, float b)=>{
            Console.WriteLine("Произведение: "+(a*b));
        };
        func+=(float a, float b)=>{
            if(b==0) {
                Console.WriteLine("На 0 делить нельзя");
                return;
            }
            Console.WriteLine("Частное: "+(a/b));
        };

        func(10, 0);
    }
}