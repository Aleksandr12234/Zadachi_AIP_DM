using System.Collections;

class Humen{
    public string FIO;
    public List<Phone> phones;

    public Humen(string FIO){
        this.FIO=FIO;

        phones=new List<Phone>();
    }

    public void addPhone(Phone p){
        phones.Add(p);
    }
}