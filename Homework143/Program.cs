using static System.Formats.Asn1.AsnWriter;

namespace Homework143
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store<Product> store = new Store<Product>();

            store.Add(new Product(1, "PC", 21200, "IT", 30));
            store.Add(new Product(2, "CPU", 32200, "IT", 43));
            store.Add(new Product(3, "Xiaomi", 12220, "Fruits", 22));
            store.Add(new Product(4, "Iphone", 122225, "Fruits", 27));

            store.Remove(4);


            var a = store.GetProductById(1);
            Console.WriteLine(a);

            store.UpdateQuantity(1, 10);

            store.UpdatePrice(1, 1000);

            var b = store.GetProductsByCategory("IT");
            foreach (var item in b)
            {
                Console.WriteLine(item.Category);
            }

            var c = store.GroupByCategory();
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }



        }
    }
}
