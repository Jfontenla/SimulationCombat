using MyStoreSolid_And_xUnit.Entities;
using System;
using Xunit;

namespace MyStoreSolid_And_xUnit.Test
{
    public class OrderShould
    {
        [Fact]
        public void Constructor_NullOrEmptyOrderCode_ThrowException()
        {
            //Arrange
            var orderCode="";
            //Act
            //Assert
            Assert.Throws<ArgumentException>(()=> new Order(orderCode));
        }

        [Fact]
        public void Constructor_InstanceOrder_AssertNotNull()
        {
            //Arrange
            var orderCode = "Cod123";
            //Act
            var sut = new Order(orderCode);
            //Assert
            Assert.NotNull(sut);
        }


    }
}
