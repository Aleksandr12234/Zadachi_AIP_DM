public class Libraly{
    public List<Book> books;

    public Libraly(){
        books=new List<Book>();
    }
}

public struct Book{
    public string autor, name, yearOfPublication, publisher;
    public Date date;

    public Book(string[] info){
        autor=info[0];
        name=info[1];
        yearOfPublication=info[2];
        publisher=info[3];
        date=new Date(info[4], info[5]);
    }

    public Book(string autor, string name, string yearOfPublication, string publisher, string dateOfissue, string dateOfReturn){
        this.autor=autor;
        this.name=name;
        this.yearOfPublication=yearOfPublication;
        this.publisher=publisher;
        date=new Date(dateOfissue, dateOfReturn);
    }

    public string info(){
        return $"{autor} {name} {yearOfPublication} {publisher} {date.dateOfissue} {date.dateOfReturn}";
    }
}

public struct Date{
    public string dateOfissue, dateOfReturn;
    
    public Date(string dateOfissue, string dateOfReturn){
        this.dateOfissue=dateOfissue;
        this.dateOfReturn=dateOfReturn;
    }
}