internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            //чтение
            StreamReader sr = new StreamReader("input.txt");
            List<string> forOutputFile=new List<string>();
            
            string line = sr.ReadLine();
            while (line != null)
            {
                foreach(char i in line){
                    int a=Convert.ToInt32(i);
                    if(a%2!=0){
                        forOutputFile.Add(line);
                        break;
                    }
                }

                line = sr.ReadLine();
            }
            sr.Close();

            //запись
            StreamWriter sw = new StreamWriter("output.txt");
            
            foreach(string i in forOutputFile){
                sw.WriteLine(i);
            }
            sw.Close();
        }
        catch (Exception) { }
    }
}