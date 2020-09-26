using System;
using System.Collections.Generic;
using System.Text;

namespace EighthDay
{
    class UseInterfaceReplaceDelegate
    {

        static void Main(string[] args)
        {
            WrapFactoryTwo factoryTwo = new WrapFactoryTwo();                                                                                               
            PizzaFactory pizza = new PizzaFactory();
            ToyCarFactory carFactory = new ToyCarFactory();

            BoxTwo box3 = new BoxTwo();
            BoxTwo box2 = new BoxTwo();

            box3 = factoryTwo.WrapProduct(pizza);
            box2 = factoryTwo.WrapProduct(carFactory);

            Console.WriteLine(box3.Product.Name+"   "+box3.Product.Price);
            Console.WriteLine(box2.Product.Name+"   "+box2.Product.Price);
        }

    }

    class ProductTwo
    {
        public string Name { get; set; }
        public double Price { get; set; }


    }

    class BoxTwo
    {
        public ProductTwo Product { get; set; }
    }

    class WrapFactoryTwo
    {
        public BoxTwo WrapProduct(IBaseProductFactory baseProduct)
        {
            BoxTwo box = new BoxTwo();
            ProductTwo product = baseProduct.MakeProduct();
            box.Product = product;
            return box;
        }
    }

    interface IBaseProductFactory
    {
        public ProductTwo MakeProduct();
    }

    class PizzaFactory : IBaseProductFactory
    {
        public ProductTwo MakeProduct()
        {
            ProductTwo product = new ProductTwo
            {
                Price = 20,
                Name = "Pizza"
            };
            return product;
        }
    }

    class ToyCarFactory : IBaseProductFactory
    {
        public ProductTwo MakeProduct()
        {
            ProductTwo product = new ProductTwo
            {
                Price = 50,
                Name = "Toycar"
            };
            return product;
        }
    }
}
