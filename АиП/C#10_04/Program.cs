internal class Program
{
    private static void Main(string[] args)
    {
        Libraly libraly=new Libraly();
        
        while(true){
            Console.Clear();
            Console.WriteLine("1) Добавить книгу");
            Console.WriteLine("2) Удалить последнюю книгу");
            Console.WriteLine("3) Выборка не выданных книг");
            Console.WriteLine("4) Выборка не возвращеных книг");
            Console.WriteLine("5) Выход");
            
            string a=""+Console.ReadLine();

            if(a=="5")break;

            switch(a){
                case "1":
                Console.WriteLine("Введите через пробел (прочерк если чего-то нет): \n"+
                "Автор Название Год_публикации Издатель Дата_выдачи Дата_возврата");
                string[] b=(""+Console.ReadLine()).Split(" ");
                libraly.books.Add(new Book(b));
                break;

                case "2":
                libraly.books.Remove(libraly.books.Last());
                break;

                case "3":
                foreach(Book i in libraly.books){
                    if(i.date.dateOfissue=="-")Console.WriteLine(i.info());
                }
                break;

                case "4":
                foreach(Book i in libraly.books){
                    if(i.date.dateOfReturn=="-" && i.date.dateOfissue!="-")Console.WriteLine(i.info());
                }
                break;
            }

            Console.ReadLine();
        }
    }


}