internal class Program
{
    private static void Main(string[] args)
    {
        List<Car> cars=new List<Car>();
        
        while(true){
            Console.Clear();
            Console.WriteLine("1) Добавить машину");
            Console.WriteLine("2) Удалить последнюю машину");
            Console.WriteLine("3) Выборка по году выпуска");
            Console.WriteLine("4) Выборка по марке");
            Console.WriteLine("5) Выборка по городу регистрации");
            Console.WriteLine("6) Выход");
            
            string a=""+Console.ReadLine();

            if(a=="6")break;

            switch(a){
                case "1":
                Console.WriteLine("Введите через пробел (прочерк если чего-то нет): \n"+
                "год_выпуска марка город_регистрации");
                string[] b=(""+Console.ReadLine()).Split(" ");
                cars.Add(new Car(b));
                break;

                case "2":
                cars.Remove(cars.Last());
                break;

                case "3":
                {
                    Console.Write("Введите год: ");
                    string zero=""+Console.ReadLine();
                    var output=from n in cars
                    where zero==n.yearOfPublic
                    select n;
                    foreach(var i in output)Console.WriteLine(i.info());
                }
                break;

                case "4":
                {
                    Console.Write("Введите марку: ");
                    string zero=""+Console.ReadLine();
                    var output=from n in cars
                    where n.mark==zero
                    select n;
                    foreach(var i in output)Console.WriteLine(i.info());
                }
                break;

                case "5":
                {
                    Console.Write("Введите город: ");
                    string zero=""+Console.ReadLine();
                    var output=from n in cars
                    where n.cityOfRegister==zero
                    select n;
                    foreach(var i in output)Console.WriteLine(i.info());
                }
                break;
            }

            Console.Write("Нажмите Enter");
            Console.ReadLine();
        }
    }
}

class Car{
    public string yearOfPublic;
    public string mark;
    public string cityOfRegister;

    public Car(string[] info){
        yearOfPublic=info[0];
        mark=info[1];
        cityOfRegister=info[2];
    }

    public string info(){
        return $"{yearOfPublic} {mark} {cityOfRegister}";
    }
}