using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanStore.Domain.Model;
using UrbanStore.Domain.Validations;

namespace UrbanStore.Domain.Tests
{
    public class CategoryUnitTest
    {
        // Description test
        [Fact]
        public void WhenDescription_IsEmptyOrNullDomain_ShouldReturnDomainException()
        {
            Action category = () => new Category("", true);

            category.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Invalid description. Description is required!");

        }
        [Fact]
        public void WhenDescription_LenghtMoreThanDomain_ShouldReturnDomainException()
        {
            Action category = () => new Category("CategoryTestNameButNowThisNameIsLongerThanTwentyCharacters", true);

            category.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Too long description.");
        }
    }
}
