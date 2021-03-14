using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle-yaptığın yazılıma yeni bir özellik ekliyorsan mevcuttaki hiçbir koduna dokunamazsın
    class Program
    {
        static void Main(string[] args)
        {
            //Data Transformation Object-taşınacak objeler-join gibi

            //ProductTest2();

            //CategoryTest();

            ProductTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }
        //ProductTest2 yi max min i deneme için yapmıştım-ProductTest e göre son haliyle düzenlemeler yapabilirsin
        //private static void ProductTest2()//Birim fiyatı 40 ie 100 arasındakileri listele
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal());

        //    foreach (var product in productManager.GetByUnitPrice(40, 100))
        //    {
        //        Console.WriteLine(product.ProductName);
        //    }
        //}

        //Aynı anda ürün tablosundan ürün isimlerini ve kategori tablosundan o ürünlerin kategorileini listeler-Join işlemi yaptık
        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetProductDetails();

            if(result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + " / " + product.CategoryName);
                }
            }
            else 
            {
                Console.WriteLine(result.Message);
            }

            
        }

    }
}
