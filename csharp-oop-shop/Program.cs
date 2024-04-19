using System.Net.Http.Headers;
using System.Xml.Linq;

namespace csharp_oop_shop
{


    public class Product
    {
        private int Codice;
        public int codice 
        {
        get { return Codice; }
        set { Codice = value; }
        }
            

            public string Name;
            public string Description;
            public double Price;
            public double Iva;

            public Product()
            {      
                Codice = 0;
                Name = string.Empty;
                Description = string.Empty;
                Price = 0;
            }   

            public Product( string name, string description, double price) :this()
            {
                Name = name;
                Description = description;
                Price = price;
            }

            public void SetName( string name )
            {
                Console.WriteLine(name);
            }

            public void SetDescription(string description)
            {
                Console.WriteLine("Descrizione:");
                Console.WriteLine(description);
            }

            public void SetPrice(double price, double iva = 0.22)
            {
                Console.WriteLine($"Il prezzo del prodotto é {price}$");
                Console.WriteLine($"Il prezzo del prodotto con l'IVA é {price + (price * iva)}");
            }

            

        }

        public static class RandomCodice 
        { 
            public static Product randomCode(this Product product)
            {
                Random rng = new Random();
                int code = rng.Next(1000, 9999);

                Console.Write($"code: {code}");

                return product;
            }
        }
        



    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Mozzarella", "lorem ipsum", 4);

            Console.WriteLine("PRODOTTO 1");


            product.randomCode(); Console.Write(" - "); product.SetName("Mozzarella");
            product.SetDescription("lorem ipsum");
            product.SetPrice(4);
            


             Product product2 = new Product("Pane", "lorem ipsum2", 1.20);

            Console.WriteLine("----------------------");

            Console.WriteLine("PRODOTTO 2");
            product.randomCode(); Console.Write(" - "); product.SetName("Pane");
            product.SetDescription("lorem ipsum2");
            product.SetPrice(1.20);



            Product product3 = new Product("Pasta e fagioli", "lorem ipsum3", 8.50);

            Console.WriteLine("----------------------");

            Console.WriteLine("PRODOTTO 3");

            product.randomCode(); Console.Write(" - "); product.SetName("Pasta e fagioli");
            product.SetDescription("lorem ipsum3");
            product.SetPrice(8.50);
        }
    }
}
