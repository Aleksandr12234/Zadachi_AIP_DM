public class Car{
    string yearManufacture, carMake, owner;
    public bool clean;

    public Car(string ym, string cm, string owner, bool clean)
    {
        yearManufacture=ym;
        carMake=cm;
        this.owner=owner;
        this.clean=clean;
    }
}