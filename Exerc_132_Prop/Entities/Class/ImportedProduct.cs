using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_132_Prop.Entities.Class
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
    
        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee) : base (name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public sealed override string PriceTag()
        {
            return Name + " $ "+ TotalPrice() + " (Customs fee: $ " + CustomsFee + ")";
        }
    }
}
