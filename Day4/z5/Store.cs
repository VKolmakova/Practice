using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace z5
{
    class Store
    {
        private Product[] products;

        public void setTmp(Product[] product)
        {
            this.products = product;
        }
        public void printInformation()
        {

            foreach (Product product in products)
            {
                Console.WriteLine(product.getName());
                Console.WriteLine($"Цена: {product.getPrice()}p");
                Console.WriteLine($"Продается в: {product.getNameOfStore()}");
                Console.WriteLine();

            }
        }
    
    }
}
