using System.Drawing;

class Program
{
    static int[] massive=new int[]{10, 12, 23, 98, 123, 12341, 1234567, 1223, 123456, 123455432, 01210, -121, 1234123};

    unsafe private static void Main(string[] args)
    {
        foreach(int i in massive){
            int* ssilka=&i;
            string aktive = "" + *ssilka;

            for(int j=0; j<aktive.Length/2; j++){
                if(aktive[j]!=aktive[aktive.Length-1-j]){
                    goto Point;
                }
            }

            Console.Write(*ssilka+" ");
            Point:;
        }
        
        Console.WriteLine();
    }
}