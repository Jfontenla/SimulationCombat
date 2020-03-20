using MyStoreSolid_And_xUnit.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MyStoreSolid_And_xUnit.Test
{
    public class BookProductShould
    {
        [Theory]
        [InlineData(321,"El arte de no amargarse la vida","Libro de psicologia", 21.35,"ISBN321","Rafael SantAndreu")]
        public void BookProduct_Constructor_InstanceBook(int codeBook, string name, string description, decimal salesPrice, string isbn, string author) 
        {
            //Arrage
            //Act
            var book = new BookProduct(codeBook, name, description,salesPrice, isbn, author);
            //Assert
            Assert.NotNull(book);
        }
    }
}
