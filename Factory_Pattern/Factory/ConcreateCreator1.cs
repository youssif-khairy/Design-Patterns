using Factory_Pattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.Factory
{
    public class ConcreateCreator1 : ProductCreator
    {
        public override IProduct FactoryMethod()
        {
            return new KitchenMachine();
        }
    }
}
