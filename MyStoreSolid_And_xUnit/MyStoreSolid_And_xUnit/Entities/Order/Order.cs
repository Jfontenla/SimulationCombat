using System;
using System.Collections.Generic;
using System.Text;

namespace MyStoreSolid_And_xUnit.Entities
{
    public class Order
    {
        public string OrderCode { get; protected set; }
        public DateTime CreationDate { get; protected set; }

        public List<OrderLine> OrderLinesList { get; private set; }

        public Order(string orderCode)
        {
            if (string.IsNullOrEmpty(orderCode))
                throw new ArgumentException($"El {nameof (orderCode)} de la orden no es válido");

            OrderCode = orderCode;
            CreationDate = DateTime.UtcNow;
            OrderLinesList = new List<OrderLine>();
        }

        public void AddOrderLine(int units,decimal discount, Product product)
        {
            this.OrderLinesList.Add(OrderLine.CreateLine(units,discount, product));
        }

        public override string ToString()
        {
            return $"{OrderCode} {CreationDate} {OrderLinesList.ToString()}";
        }

    }
}
