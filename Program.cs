using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift24
{

    public class Product
    {
        // Private fiels
        private string name;
        private double price;
        private int stock;

        //Constructor
        public Product(string name, double price, int stock)
        {
            this.name = name;
            this.price = price;
            this.stock = stock;

        }
        public void SetName(string name)
        { 
            this.name = name;
        }
        public string GetName()
        { 
        return this.name;
        }
        public void SetPrice(double price) 
        { 
        this.price = price;
        }
        public double GetPrice()
        { 
        return price;
        }
        public void SetQuantity(int stock)
        {
            this.stock = stock;
        }
        public int GetQuantity()
        { 
        return stock;
        }
        public string GetProductsDetails()
        { 
        return $"Product name: {name}, Price: {price}, Quantity: {stock}";
        }
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product Name: {name}");
            Console.WriteLine($"Price: {price:C}");
            Console.WriteLine($"Stock : {stock}");
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Product product = new Product("Phone", 599, 5);
                Console.WriteLine(product.GetProductsDetails());

                product.SetName("Laptop");
                product.SetPrice(999.99);
                product.SetQuantity(10);

                Console.WriteLine(product.GetProductsDetails());
                
                
                
                Console.ReadLine();
            }
        }
    }
}
