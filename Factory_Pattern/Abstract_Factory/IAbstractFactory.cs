using Factory_Pattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.Abstract_Factory
{
    //Abstract Factory Is factory of factories 
    //Means : Factory Contain Multiple of Facotries
    //Generate Families of products
    public interface IAbstractFactory
    {
        IProduct getProduct1();
        IAnotherProductCategory getProduct2();
    }
}
