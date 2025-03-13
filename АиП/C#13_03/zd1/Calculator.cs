
public delegate int CalDel(Calculator calculator);

public class Calculator{
    public int a,b;

    public Calculator(int a, int b)
    {
        this.a=a;
        this.b=b;
    }

    public static int Add(int a, int b){
        return a+b;
    }

    public static int Subtract(int a, int b){
        return a-b;
    }

    public static int Multiply(int a, int b){
        return a*b;
    }

    public static int Divide(int a, int b){
        if(b==0)return 0;
        return a/b;
    }
}