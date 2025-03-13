using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Phone> phones=new List<Phone>();
        while (true)
        {
            Console.Write("Введите оператора и номер телефона через пробел (enter чтобы закончить): ");
            string b=""+Console.ReadLine();
            if(b.Length<3) break;
            string[] zero=b.Split(" ");
            phones.Add(new Phone(zero[0], zero[1]));
        }

        Dictionary<string, int> count=new Dictionary<string, int>();

        foreach(Phone i in phones){
            if(count.ContainsKey(i.telOperator)){
                count[i.telOperator]+=1;
            }
            else{
                count.Add(i.telOperator, 1);
            }
        }

        foreach(var i in count){
            Console.WriteLine($"Оператор {i.Key} встречается {i.Value} раз(а)");
        }
    }
}