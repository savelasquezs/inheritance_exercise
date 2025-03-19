using System;
using System.Collections.Generic;

namespace inheritance_exercise
{
    public class FoodProductData
    {
        public List<string> ProductNames { get; }
        public List<int> Prices { get; }
        public List<string> Descriptions { get; }
        public List<string> Categories { get; }

        static Random random = new Random();

        public FoodProductData()
        {
            ProductNames = new List<string> { "Bread", "Milk", "Eggs", "Cheese", "Butter" };
            Prices = new List<int> { 2000, 3000, 4000, 5000, 6000 };
            Descriptions = new List<string> {
                    "Bread is a staple food prepared from a dough of flour and water, usually by baking. Throughout recorded history, it has been a prominent food in large parts of the world.",
                    "Milk is a nutrient-rich, white liquid food produced by the mammary glands of mammals. It is the primary source of nutrition for young mammals, including breastfed human infants before they are able to digest solid food.",
                    "Eggs are the prefered food of doctor Baiter",
                    "Cheese is a dairy product, derived from milk and produced in wide ranges of flavors, textures and forms by coagulation of the milk protein casein.",
                    "Butter is a dairy product made from the fat and protein components of milk or cream. It is a semi-solid emulsion at room temperature, consisting of approximately 80% butterfat."
                };
            Categories = new List<string> { "Bakery", "Dairy" };
        }

        // Generate and save food products using product lists
        public void GenerateAndSaveFoodProducts(List<Product> products)
        {
            for (int i = 0; i < ProductNames.Count; i++)
            {
                string foodCategory = Categories[random.Next(0, Categories.Count)];
                products.Add(new FoodProduct(ProductNames[i], Descriptions[i], Prices[i], foodCategory));
            }  
        }
    }
}