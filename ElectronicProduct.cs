using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_exercise
{
    class ElectronicProduct : Product
    {
        private string _brand;
        private string _model;

        public string Brand
        {
            get { return _brand; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _brand = value;
                }
                else
                {
                    Utils.showError("Brand cannot be empty");
                    throw new ArgumentException("Brand cannot be empty.");
                }
            }
        }

        public string Model
        {
            get { return _model; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _model = value;
                }
                else
                {
                    throw new ArgumentException("Model cannot be empty.");
                }
            }
        }

        public ElectronicProduct(string name, string description, double price, string brand, string model)
            : base(name, price, description, "Electronics")
        {
            Brand = brand;
            Model = model;
        }

        public string GetBrandInfo()
        {
            return $"Brand: {Brand}\nModel: {Model}";
        }

        public override string GetDetails()
        {
            string details = base.GetDetails() + $"\n{GetBrandInfo()}";
            return details;
        }
    }
}
