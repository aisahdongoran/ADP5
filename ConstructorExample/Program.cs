using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Example
{
   class Cart
    {
        private List<string> items = new List<string>();

        public Cart()
        {
            items = new List<string>();
        }
        
        public void AddItems (string item)
        {
            items.Add(item);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();
            cart.AddItems("Ayam");

            Console.ReadKey();

        }
    }
}
