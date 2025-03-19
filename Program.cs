using System;
using System.IO;
namespace inheritance_exercise
{
    class Program
    {
        static void Main()
        
        {
            Random random = new Random();
            //food product names
            List<string> foodProductNames = new List<string> { "Bread", "Milk", "Eggs", "Cheese", "Butter" };
            List<int> foodPrices = new List<int> { 2000, 3000, 4000, 5000, 6000 };
            List<string> foodDescriptions = new List<string> {
               "Bread is a staple food prepared from a dough of flour and water, usually by baking. Throughout recorded history, it has been a prominent food in large parts of the world.",
               "Milk is a nutrient-rich, white liquid food produced by the mammary glands of mammals. It is the primary source of nutrition for young mammals, including breastfed human infants before they are able to digest solid food.",
               "Eggs are the prefered food of doctor Baiter",
               "Cheese is a dairy product, derived from milk and produced in wide ranges of flavors, textures and forms by coagulation of the milk protein casein.",
               "Butter is a dairy product made from the fat and protein components of milk or cream. It is a semi-solid emulsion at room temperature, consisting of approximately 80% butterfat." };

            List<string> foodCategories = new List<string> { "Bakery", "Dairy" };
            List<string> electronicBrands = new List<string> { "Samsung", "Lenovo" };
            List<string> electronicModels = new List<string> { "Galaxy S21", "thinkpad", };
            List<string> electronicProductNames = new List<string> { "Cellphone", "Computer" };
            List<string> electronicDescriptions = new List<string> {
               "A cellphone is a portable telephone that can make and receive calls over a radio frequency link while the user is moving within a telephone service area.", "A cellphone is a portable telephone that can make and receive calls over a radio frequency link while the user is moving within a telephone service area.",
               " A computer is a device useful for programming tasks"
           };
            List<int> electronicPrices = new List<int> { 200000, 300000 };

            List<Product> products = new List<Product>();
            for (int i = 0; i < foodProductNames.Count; i++)
            {
                
                string foodCategory = foodCategories[random.Next(0,foodCategories.Count)];
                products.Add(new FoodProduct(foodProductNames[i], foodDescriptions[i], foodPrices[i], foodCategory));
            }

            List<ElectronicProduct> electronicProducts = new List<ElectronicProduct>();
            for (int i = 0; i < electronicProductNames.Count; i++)
            {
                products.Add(new ElectronicProduct(electronicProductNames[i], electronicDescriptions[i], electronicPrices[i], electronicBrands[i], electronicModels[i]));
            }

            foreach (var product in products)
            {
                Console.WriteLine(product.GetDetails());
               
            }
            


        } 
    }
}
