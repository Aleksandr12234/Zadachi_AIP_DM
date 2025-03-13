public delegate void Moika(Car car);

class Garages{

    event Moika dirtyСar;
    public List<Car> cars=new List<Car>();

    public Garages()
    {
        dirtyСar=CarWash.wash;
    }

    public void check()
    {
        foreach(Car i in cars){
            if(!i.clean) dirtyСar(i);
        }
    } 
}

class CarWash{
    public static void wash(Car car){
        car.clean=true;
    }
}