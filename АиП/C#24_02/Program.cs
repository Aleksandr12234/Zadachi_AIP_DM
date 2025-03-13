internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Выражение: ");
        string stroka=""+Console.ReadLine();
        Stack<string> skobki =new Stack<string>();

        foreach(char i in stroka){
            if(skobki.Count<=0){
                if("{[()]}".Contains(i)) skobki.Push(""+i);
                continue;
            }
            if("{[(".Contains(i))skobki.Push(""+i);
            else if(skobki.Peek()=="{" && i=='}')skobki.Pop();
            else if(skobki.Peek()=="[" && i==']')skobki.Pop();
            else if(skobki.Peek()=="(" && i==')')skobki.Pop();
        }

        Console.WriteLine("Последовательность скобок "+(skobki.Count>0 ? "неверна" : "верна"));
    }
}