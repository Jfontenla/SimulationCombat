using System;
using System.Collections.Generic;
using System.Text;

namespace MyStoreSolid_And_xUnit.Entities
{
    public class BookProduct : Product
    {
        public string Isbn { get; protected set; }
        public string Author { get; protected set; }

        public BookProduct(int code,string name,string description, decimal salesPrice, string isbn, string author): 
            base(code,name,description,salesPrice )
        {
            Isbn = isbn;
            Author = author;
        }

        public BookProduct(int productCode, string name, string description, decimal salesPrice) : base(productCode, name, description, salesPrice)
        {
        }

        public override Product CreateProduct(int productCode, string name, string description, decimal salesPrice)
        {
            return new BookProduct( productCode, name, description, salesPrice);
        }

        public override string ToString()
        {
            return $"{base.ToString()}+ el autor {Author}";
        }
    }
}
