internal class Program
{
    private static void Main(string[] args)
    {
        Calculator obj=new Calculator(10, 2);

        CalDel calDel=delegate(Calculator calculator){
            int res=Calculator.Add(calculator.a, calculator.b);
            res= Calculator.Subtract(res, calculator.b);
            res= Calculator.Divide(res, calculator.b);
            return res;
        };

        Calculator obj1=new Calculator(5, 2);

        CalDel calDel1=delegate(Calculator calculator){
            int res=Calculator.Multiply(calculator.a, calculator.b);
            res=Calculator.Add(res, calculator.a);
            return res;
        };

        Console.WriteLine(calDel(obj));
        Console.WriteLine(calDel1(obj1));
    }
}