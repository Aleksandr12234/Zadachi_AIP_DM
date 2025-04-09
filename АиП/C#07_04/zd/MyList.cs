public class MyList<T>{
    List<T> array=new List<T>();

    public void add(T a){
        array.Add(a);
    }

    public void remove(int a){
        array.RemoveAt(a);
    }

    public T output(int a){
        return array[a];
    }
}