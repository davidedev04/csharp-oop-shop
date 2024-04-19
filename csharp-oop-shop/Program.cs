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
                Iva = 0;
            }   

            public Product( string name, string description, double price, double iva) :this()
            {
                Name = name;
                Description = description;
                Price = price;
                Iva = iva;
            }

            public void SetName( string name )
            {
                Console.WriteLine($"Il nome del prodotto é {name}");
            }

            public void SetDescription(string description)
            {
                Console.WriteLine("La descrizione del prodotto é:");
                Console.WriteLine(description);
            }

            public void SetPrice(double price)
            {
                Console.WriteLine($"Il prezzo del prodotto é {price}$");
            }

            public void SetIva(double price, double iva)
            {
                Console.WriteLine($"Il prezzo del prodotto con l'IVA é {price + (price * iva)}");
            }

        }

        public static class RandomCodice 
        { 
            public static Product randomCode(this Product product)
            {
                Random rng = new Random();
                int code = rng.Next(1000, 9999);

                Console.WriteLine($"Il codice del prodotto é {code}");

                return product;
            }
        }
        



    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Mozzarella", "lorem ipsum", 4, 0.04);

            Console.WriteLine("PRODOTTO 1");


            product.randomCode();
            product.SetName("Mozzarella");
            product.SetDescription("lorem ipsum");
            product.SetPrice(4);
            product.SetIva(4, 0.04);


             Product product2 = new Product("Pane", "lorem ipsum2", 1.20, 0.10);

            Console.WriteLine("----------------------");

            Console.WriteLine("PRODOTTO 2");
            product.randomCode();
            product.SetName("Pane");
            product.SetDescription("lorem ipsum2");
            product.SetPrice(1.20);
            product.SetIva(1.20, 0.10);

        }
    }
}
