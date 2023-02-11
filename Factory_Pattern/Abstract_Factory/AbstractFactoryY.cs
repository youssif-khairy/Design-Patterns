using Factory_Pattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.Abstract_Factory
{
    public class AbstractFactoryY : IAbstractFactory
    {
        public IProduct getProduct1()
        {
            return new MicroWave();
        }

        public IAnotherProductCategory getProduct2()
        {
            return new AnotherProductCategory1();
        }
    }
}
