delegate void Out(string[] s, string m);

internal class Program
{
    private static void Main(string[] args)
    {
        Out output=(string[] s, string m)=>{
            foreach(string i in s){
                if(i.IndexOf(m)==0)Console.WriteLine(i);
            }
        };

        string[] s = ["123", "213", "231"];
        string m="21";

        output(s,m);
    }
}