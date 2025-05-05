internal class Program
{
    private static void Main(string[] args)
    {
        BaseData baseData=new BaseData();

        baseData.movementOfProducts.Add(new MovementOfProduct(1, 3, "24.04.23", 20, 100));
        baseData.movementOfProducts.Add(new MovementOfProduct(2, 1, "02.12.23", 30, 1000));
        baseData.movementOfProducts.Add(new MovementOfProduct(3, 2, "15.08.23", 8, 20));

        baseData.products.Add(new Product(1, "молоко"));
        baseData.products.Add(new Product(2, "телефон"));
        baseData.products.Add(new Product(3, "что-то"));

        baseData.suppliers.Add(new Supplier(1, "хонда", "8252424324"));
        baseData.suppliers.Add(new Supplier(2, "нива", "898436284"));
        baseData.suppliers.Add(new Supplier(3, "кампания", "89634872"));

        //необходимо выдать все товары сгруппированные по поставщикам.
        {
            var zero= from n in baseData.movementOfProducts
            orderby n.numberOfSupplier
            select n;

            var q=from n in baseData.products
            where n.number==zero.First().numberOfProdct
            select n;
            foreach(MovementOfProduct i in zero){
                var w=from n in baseData.products
                where n.number==i.numberOfProdct
                select n;
                q = q.Union(w);
                q = q.Distinct();
            }
            foreach(Product i in q)Console.WriteLine(i.info());
        }

        // определить суммарную стоимость товаров по дате поставки
        {
            string date="";//переменная, определяющая по какой дате считать

            var zero=from n in baseData.movementOfProducts
            where n.date.Contains(date)
            select n;

            int sum=0;
            foreach(MovementOfProduct i in zero)sum+=i.count*i.price;
            Console.WriteLine(sum);
        }

        // выдать поставщика поставившего товар на большую сумму
        {
            var zero = from n in baseData.movementOfProducts
            group n by n.numberOfSupplier;

            int maxSum=0;
            int number=0;
            for(int i=0; i<zero.Count(); i++){
                int sum=0;
                foreach(var j in zero.ElementAt(i))sum+=j.count*j.price;
                if(sum>maxSum){
                    maxSum=sum;
                    number=zero.ElementAt(i).First().numberOfSupplier;
                }
            }

            var one = from n in baseData.suppliers
            where n.number==number
            select n;

            Console.WriteLine(one.First().info());
        }
    }
}