using System;
using System.Collections.Generic;

namespace inheritance_exercise
{
    public class ElectronicProductData
    {
        public List<string> Brands { get; }
        public List<string> Models { get; }
        public List<string> ProductNames { get; }
        public List<int> Prices { get; }
        public List<string> Descriptions { get; }

        public ElectronicProductData()
        {
            Brands = new List<string> { "Samsung", "Lenovo" };
            Models = new List<string> { "Galaxy S21", "thinkpad" };
            ProductNames = new List<string> { "Cellphone", "Computer" };
            Prices = new List<int> { 200000, 300000 };
            Descriptions = new List<string> {
                "A cellphone is a portable telephone that can make and receive calls over a radio frequency link while the user is moving within a telephone service area.",
                "A cellphone is a portable telephone that can make and receive calls over a radio frequency link while the user is moving within a telephone service area.",
                "A computer is a device useful for programming tasks."
            };
        }

        // Generate and save electronic products using product lists
        public void GenerateAndSaveElectronicProducts(List<Product> products)
        {
            for (int i = 0; i < ProductNames.Count; i++)
            {
                products.Add(new ElectronicProduct(ProductNames[i], Descriptions[i], Prices[i], Brands[i], Models[i]));
            }
        }
    }
}