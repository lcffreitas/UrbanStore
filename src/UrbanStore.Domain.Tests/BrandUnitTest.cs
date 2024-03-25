using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrbanStore.Domain.Tests
{
    public class BrandUnitTest
    {
        [Fact]
        public void WhenBrandName_LenghtMoreThan_DomainException()
        {
            // Arrange
            var brand = new Brand("BrandName");

            // Act
            Action act = () => brand.SetName("NameTestLongerThan30CharactersUnitTestForDomainException");

            // Assert
            Assert.Throws<DomainException>(act);
        }
    }
}