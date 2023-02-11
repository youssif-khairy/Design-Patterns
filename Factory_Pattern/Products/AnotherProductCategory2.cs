using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.Products
{
    public class AnotherProductCategory2 : IAnotherProductCategory
    {
        public string getAnotherProduct()
        {
            return "This is Another Product 2";
        }
    }
}
