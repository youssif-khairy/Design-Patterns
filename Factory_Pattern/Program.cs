//Creational DP

/*
 Main Diffrence between Factory and Abstract Factory is That 

Factory Use Method to generate "ONE PRODUCT"

Abstract Factory Used To Generate Multiple Products

 */


/*
 Diffrence between Factory and strategy is That

Factory : Which type to be created

Strategy : which behavior based on type to be created 

example : 
you may create any animal as : cow , donkey , rat ==> Factory

each move as : MoveUp() , MoveRight() ==> Strategy
 
 */


#region Factory

using Factory_Pattern.Abstract_Factory;
using Factory_Pattern.Factory;
using Factory_Pattern.Products;

ProductCreator productCreator = new ConcreateCreator2();


Console.WriteLine(productCreator.AnotherMethod());
#endregion


#region Abstract Factory

IAbstractFactory factory = new AbstractFactoryX();

Console.WriteLine(GetFactoryProducts(factory));

string GetFactoryProducts(IAbstractFactory factory)
{
    var product1 = factory.getProduct1();
    var product2 = factory.getProduct2();

    return $"This is Factory and have products ${product1.getProduct()} :::: ${product2.getAnotherProduct()}";
}
#endregion