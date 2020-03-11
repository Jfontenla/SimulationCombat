using System;
using System.Collections.Generic;
using System.Text;

namespace MyStoreSolid_And_xUnit.Entities
{
    public abstract class Product
    {
        public int ProductCode { get;protected set; }
        public string Name { get;protected set; }
        public string Description { get; protected set; }
        public decimal SalesPrice { get; protected set; }

        protected Product(int productCode, string name, string description, decimal salesPrice)
        {
            if (productCode < 1) 
                throw new ArgumentOutOfRangeException($"El argumento {nameof(productCode)} ha de ser mayor que 0");

            if (salesPrice < 0.01m) 
                throw new ArgumentOutOfRangeException($"El argumento {nameof(salesPrice)} ha de ser mayor que 0");

            if (string.IsNullOrEmpty(name))
                throw new ArgumentException($"El atributo {nameof(name)} no puede ir vacío");

            if (string.IsNullOrEmpty(description))
                throw new ArgumentException($"El atributo {nameof(description)} no puede ir vacío");

            ProductCode = productCode;
            Name = name;
            Description = description;
            SalesPrice = salesPrice;
        }


        public abstract Product CreateProduct(int productCode, string name, string description, decimal salesPrice);

        public override string ToString()
        {
            return $"El producto {Name} con codigo {ProductCode} se vende a {SalesPrice}";
        }

    }
}
