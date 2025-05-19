class Program
{

    unsafe private static void Main(string[] args)
    {

        int* massive = stackalloc int[] {10, 1, 22, 40};

        for (int i= 0; i< 4; i++)
        {
            string aktive = "" + massive[i];

            for (int j = 0; j < aktive.Length / 2; j++)
            {
                if (aktive[j] != aktive[aktive.Length - 1 - j])
                {
                    goto Point;
                }
            }

            Console.Write(massive[i] + " ");
        Point:;
        }
        
        Console.WriteLine();
    }
}