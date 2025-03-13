interface Figuri{
    public float getS();
    public float getP();
}

class Rect: MasterClass, Figuri{
    int a;
    public Rect(int a){
        this.a=a;
        name="Квадрат";
    }
    public float getS(){
        return a*a;
    }

    public float getP(){
        return a*4;
    }
}

class Circle: MasterClass, Figuri{
    int r;
    public Circle(int r){
        this.r=r;
        name="Окружность";
    }
    public float getS(){
        return 3.14f*r*r;
    }

    public float getP(){
        return 2*3.14f*r;
    }
}

class Rectangle: MasterClass, Figuri{
    int a;
    public Rectangle(int a){
        this.a=a;
        name="Треугольник";
    }
    public float getS(){
        return (float)(a*a*Math.Sqrt(3))/4;
    }

    public float getP(){
        return a*3;
    }
}