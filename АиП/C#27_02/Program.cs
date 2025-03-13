internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите строку (элементы через пробел): ");

        string[] s=(""+Console.ReadLine()).Split(" ");

        Stack<float> chisla= new Stack<float>();

        foreach(string i in s){
            if(float.TryParse(i, out float j)){
                chisla.Push(j);
            }else{
                if(chisla.Count<=1){
                    Console.WriteLine("неверный ввод уравнения");
                    return;
                }
                float result=0;
                switch(i){
                    default: Console.WriteLine("неверный ввод уравнения"); break;
                    case "+":
                        result=chisla.Pop()+chisla.Pop();
                    break;
                    case "-":
                        result=-chisla.Pop()+chisla.Pop();
                    break;
                    case "*":
                        result=chisla.Pop()*chisla.Pop();
                    break;
                    case "/":
                        float a=chisla.Pop();
                        float b=chisla.Pop();
                        if(a==0){
                            Console.WriteLine("неверный ввод уравнения");
                            return;
                        }
                        result=b/a;
                    break;
                }

                chisla.Push(result);
            }

        }


        Console.WriteLine("Ответ: "+chisla.Peek());
    }
}