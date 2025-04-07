internal class Program
{
    private static void Main(string[] args)
    {
        MyList<int> myList=new MyList<int>();

        myList.add(1);
        myList.add(2);
        myList.add(3);

        myList.remove(1);

        Console.WriteLine(myList.output(0));
        Console.WriteLine(myList.output(1));
    }
}