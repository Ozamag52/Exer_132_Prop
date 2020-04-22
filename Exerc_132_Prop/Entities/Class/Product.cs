using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_132_Prop.Entities.Class
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    
        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string PriceTag()
        {
            return Name + " $ " + Price;
        }

    }
}
