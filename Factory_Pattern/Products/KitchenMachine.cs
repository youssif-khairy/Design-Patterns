using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.Products
{
    public class KitchenMachine : IProduct
    {
        public string getProduct()
        {
            return "This is kitchen Machine";
        }
    }
}
