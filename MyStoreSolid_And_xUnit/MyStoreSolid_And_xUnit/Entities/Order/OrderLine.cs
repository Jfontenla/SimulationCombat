using System;
using System.Collections.Generic;
using System.Text;

namespace MyStoreSolid_And_xUnit.Entities
{
    public class OrderLine
    {
        public int Units { get; private set; }
        public decimal PriceForUnit { get; private set; }
        public decimal Discount { get; private set; }

        public decimal TotalPrice { get 
            {
                return Units * (PriceForUnit - Discount);
            } }
        public virtual Product Product { get; set; }
        private OrderLine(int units, decimal discount,Product product)
        {
            if (units < 1) 
                throw new ArgumentOutOfRangeException($"El argumento {nameof(units)} ha de ser mayor que 0");

            if (discount < 0.01m) 
                throw new ArgumentOutOfRangeException($"El argumento {nameof(discount)} ha de ser mayor que 0");

            Units = units;
            PriceForUnit = product.SalesPrice;
            Discount = discount;
            Product = product;
        }

        public static OrderLine CreateLine (int units, decimal discount, Product product)
        {
            return new OrderLine(units, discount, product);
        }

        public void ShowMeOrderLineDetail()
        {
            Console.WriteLine( $"Unidades {Units} Precio por unidad : {PriceForUnit} con un descuento de {Discount} hace un total de {TotalPrice} {Product.ToString()}" );
        }
    }
}
