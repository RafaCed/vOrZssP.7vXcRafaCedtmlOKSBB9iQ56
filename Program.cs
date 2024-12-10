using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace uppgift25
{
    class Inventory
    {
        private List<string> items;
        private Dictionary<string, (double price, int stock)> itemDetails;

        public Inventory()
        {
            items = new List<string>();
            itemDetails = new Dictionary<string, (double price, int stock)>();
        }
        public void AddItem(string productName, double price, int stock)
        {
            items.Add(productName);
            itemDetails[productName] = (price, stock);
        }
        public void RemoveItem(string productName)
        {
            if (items.Contains(productName))
            {
                items.Remove(productName);
                itemDetails.Remove(productName);
            }
        }
        public void UpdateStock(string productName, int newStock)
        {
            if (itemDetails.ContainsKey(productName))
            {
                var details = itemDetails[productName];
                itemDetails[productName] = (details.price, newStock);
            }
        }
        public void PrintItems()
        {
            Console.WriteLine("Inventory: ");
            foreach ( var item in items)
            {
                var details = itemDetails[item];
                Console.WriteLine($"Product: {item}, Price: {details.price}, Stock: {details.stock}");
            }
        }
        public void FindMostExpensiveItem()
        {
            string mostExpensive = null;
            double highestPrice = 0;

            foreach (var item in items)
            {
            var details = itemDetails[item];
            if (details.price > highestPrice) 
            {
                highestPrice = details.price;
                mostExpensive = item;
            }
           }
            if (mostExpensive != null) 
            {
                Console.WriteLine($"The most expensive item is: {mostExpensive} with price: {highestPrice}"); 
            }
        }
        public void TotalInventoryValue()
        { 
            double totalValue = 0;

            foreach (var item in items)
            {
                var details = itemDetails[item];
                double itemValue = details.price * details.stock;
                totalValue += itemValue;
                Console.WriteLine($"Total value for {item}: {itemValue}");
            }
            Console.WriteLine($"Total inventory value: {totalValue}");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Inventory inventory = new Inventory();

                inventory.AddItem("Laptop", 1200.50, 7);

                inventory.AddItem("Smartphone", 799.99, 12);

                inventory.AddItem("Tablet", 399.99, 15);


                inventory.PrintItems();

                inventory.UpdateStock("Laptop", 5);

                inventory.RemoveItem("Tablet");
                
                inventory.FindMostExpensiveItem();

                inventory.TotalInventoryValue();

                Console.ReadLine();
            }
        }
    }
}
