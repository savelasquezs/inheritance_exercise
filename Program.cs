using System;
using System.Collections.Generic;

namespace inheritance_exercise
{
    class Program
    {
        
        static ElectronicProductData electronicProductData = new ElectronicProductData();
        static FoodProductData foodProductData = new FoodProductData();
        static List<Product> products = new List<Product>();
        static void Main()
        {


            foodProductData.GenerateAndSaveFoodProducts(products);
            electronicProductData.GenerateAndSaveElectronicProducts(products);
            foreach (var product in products)
            {
                Console.WriteLine(product.GetDetails());
            }
            Console.ReadKey();
        }
    }
}