using MyStoreSolid_And_xUnit.Entities;
using System;

namespace MyStoreSolid_And_xUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookPrueba = new BookProduct(1234, "Libro de ejemplo","Esta descripcion es de ejemplo", 31.21m, "ISBN321","Alberto Ca Melas");
            var firstOrder = new Order("112233");
            firstOrder.AddOrderLine(2,0.0m,bookPrueba);
            
        }
    }
}
