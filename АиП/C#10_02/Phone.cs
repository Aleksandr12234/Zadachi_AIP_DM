using System.Numerics;

class Phone{
    public string number, sity, operat, ear;

    public Phone(string number, string sity, string operat, string ear){
        this.number=number;
        this.sity=sity;
        this.operat=operat;
        this.ear=ear;
    }

    public void PrintInfo(){
        Console.WriteLine($"{number}; {sity}, {operat}, {ear}");
    }
}