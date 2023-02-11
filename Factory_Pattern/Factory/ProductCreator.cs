using Factory_Pattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.Factory
{
    public abstract class ProductCreator
    {
        public abstract IProduct FactoryMethod();

        public string AnotherMethod()
        {
            IProduct product = FactoryMethod();
            return $"This is Another method that is : ${product.getProduct()}";
        }
    }
}
