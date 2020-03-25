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
        [InlineData(326, "Las gafas de la felicidad", "Libro de psicologia", 21.35, "ISBN326", "Rafael SantAndreu")]
        public void BookProduct_Constructor_InstanceBook(int codeBook, string name, string description, decimal salesPrice, string isbn, string author) 
        {
            //Arrage & Act
            var book = new BookProduct(codeBook, name, description,salesPrice, isbn, author);
            //Assert
            Assert.NotNull(book);
        }

        [Fact]
        public void BookProduct_Construnctor_InstanceProduct()
        {
            //Arrange & Act 
            var BookProduct = new BookProduct(322,"Diseño " +
                "agil con TDD", "bla bla bla descripcion",13.25m);
            //Assert
            Assert.NotNull(BookProduct);
        }

        [Fact]
        public void BookProduct_Construnctor_AllPropertiesAreEqual()
        {
            //Arrange
            int code = 322;
            string name = "Diseño agil con TDD";
            string description = "bla bla bla descripcion";
            decimal price = 13.25m;
            //Act 
            var BookProduct = new BookProduct(code, name, description, price);
            //Assert
            Assert.Equal(BookProduct.ProductCode, code);
            Assert.Equal(BookProduct.Name, name);
            Assert.Equal(BookProduct.Description, description);
            Assert.Equal(BookProduct.SalesPrice, price);
        }


    }
}
