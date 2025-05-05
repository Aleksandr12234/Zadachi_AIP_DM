class BaseData{
    public List<Product> products=new List<Product>();
    public List<Supplier> suppliers=new List<Supplier>();
    public List<MovementOfProduct> movementOfProducts=new List<MovementOfProduct>();
}

class Product{
    public int number;
    public string name;

    public Product(int number, string name){
        this.number=number;
        this.name=name;
    }

    public string info(){
        return $"{number} {name}";
    }
}

class Supplier{
    public int number;
    public string name, phone;

    public Supplier(int number, string name, string phone){
        this.number=number;
        this.name=name;
        this.phone=phone;
    }

    public string info(){
        return $"{number} {name} {phone}";
    }
}

class MovementOfProduct{
public int numberOfProdct, numberOfSupplier, count , price;
public string date;

    public MovementOfProduct(int numberOfProdct, int numberOfSupplier, string date, int count, int price){
        this.numberOfProdct=numberOfProdct;
        this.numberOfSupplier=numberOfSupplier;
        this.date=date;
        this.count=count;
        this.price=price;
    }

    public string info(){
        return $"{numberOfProdct} {numberOfSupplier} {date} {count} {price}";
    }
}