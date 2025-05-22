

internal class Program
{
    private unsafe static void Main(string[] args)
    {
        Console.WriteLine("Введите текст:");
        string line = "";
        while (true)
        {
            string b = "" + Console.ReadLine();
            if (b == "") break;
            line += b;
        }

        int* symbols = stackalloc int[128];

        foreach (char i in line)
        {
            symbols[i] += 1;
        }

        for (int i = 0; i < 128; i++)
        {
            if (symbols[i] == 0) continue;
            Console.WriteLine(((char)i) + ": " + symbols[i]);
        }
    }
}