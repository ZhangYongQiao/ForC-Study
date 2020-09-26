using System;

namespace EighthDay
{
    class Program
    {   
        /*
        static void Main(string[] args)
        {
            ProductFactory product = new ProductFactory();
            WrapFactory wrap = new WrapFactory();

            Func<Product> func = new Func<Product>(product.MakeHanbao);
            Func<Product> func1 = new Func<Product>(product.MakeDrink);
            Action<Product> action = new Action<Product>(Log.GetProductInfo);
            //同样使用一个模板方法传入的代理，生产不同的产品
            Box box = wrap.WrapProduct(func,action);
            Box box1 = wrap.WrapProduct(func1,action);

            Console.WriteLine(box.Product.Name);    //output: 汉堡包
            Console.WriteLine(box1.Product.Name);   //output: Milk
        }
        */
    }

    class Log
    {
        public static void GetProductInfo(Product product)
        {
            Console.WriteLine("产品的生产时间为:" + DateTime.Now + ",生产的产品为:" + product.Name + ",价格为:" + product.Price);
        }
    }

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

    }

    class Box
    {
        public Product Product { get; set; }
    }

    class WrapFactory
    {
        public Box WrapProduct(Func<Product> getProduct,Action<Product> logCallBack)
        {
            Box box = new Box();
            Product product = getProduct();
            if(product.Price > 15)
                logCallBack(product);
            box.Product = product;
            return box;
        }
    }

    class ProductFactory
    {
        public Product MakeHanbao()
        {
            Product product = new Product
            {
                Name = "汉堡包",
                Price = 30
            };
            //Logger.GetProductInfo(product);
            return product;
        }

        internal Product MakeDrink()
        {
            Product product = new Product
            {
                Name = "Milk",
                Price = 3.5
            };
            //Logger.GetProductInfo(product);
            return product;
        }
    }
}
