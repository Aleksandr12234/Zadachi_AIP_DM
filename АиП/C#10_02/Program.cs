internal class Program
{
    static List<Humen> humens=new List<Humen>();
    private static void Main(string[] args)
    {
        while(true){
            Console.Clear();
            Console.WriteLine("———<Меню>———");
            Console.WriteLine("1.Задать телефон");
            Console.WriteLine("2.Вывести данные телефонов");
            Console.WriteLine("3.Выйти\n");

            string s=""+Console.ReadLine();
            if(s=="1"){
                AddPhone();
            }
            else if(s=="2"){
                OutputInfo();
            }
            else if(s=="3")break;
            else Console.WriteLine("Нет такой команды");
        }
    }

    private static void AddPhone(){
        Console.WriteLine("Введите через пробел (ФИО номер город оператор_связи год_подключения):");
        string[] s=(""+Console.ReadLine()).Split(" ");
        bool b=false;
        foreach(Humen i in humens){
            if(i.FIO==s[0]){
                b=true;
                i.addPhone(new Phone(s[1], s[2], s[3], s[4]));
            }
        }
        if(!b){
            humens.Add(new Humen(s[0]));
            humens[humens.Count-1].addPhone(new Phone(s[1], s[2], s[3], s[4]));
        }
    }

    private static void OutputInfo(){
        Console.Write("Введите данные поиска (номер/город/оператор связи/год подключения) или \"-\": ");
        string s=""+Console.ReadLine();

        foreach(Humen i in humens){
            Console.WriteLine("Устройства "+i.FIO+":");
            bool b=true;
            foreach(Phone j in i.phones){
                if(s=="-" || s==j.number || s==j.sity || s==j.operat || s==j.ear){
                    Console.Write("\t");
                    j.PrintInfo();
                    b=false;
                }
            }
            if(b)Console.WriteLine("\tНет данных, удовлетворяющему поиску");
        }

        Console.WriteLine("Нажмите ENTER");
        Console.ReadLine();
    }
}