using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanStore.Domain.Model;
using UrbanStore.Domain.Validations;

namespace UrbanStore.Domain.Tests
{
    public class UserUnitTest
    {
        // Name test
        [Fact]
        public void WhenName_IsEmptyOrNullDomain_ShouldReturnDomainException()
        {
            Action user = () => new User("", "testEmail", "testPassword", "testPhoneNumber", DateTime.Now , "testCpf" );

            user.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Invalid name. Name is required!");
        }
        [Fact]
        public void WhenName_LenghtMoreThanDomain_ShouldReturnDomainException()
        {
            Action user = () => new User("ProductNameButNowThisNameIsLongerThanThirtyCharacters", "testEmail", "testPassword", "testPhoneNumber", DateTime.Now , "testCpf" );

            user.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Too long name.");
        }
        // Email test
        [Fact]
        public void WhenEmail_IsEmptyOrNullDomain_ShouldReturnDomainException()
        {
            Action user = () => new User("testName", "", "testPassword", "testPhoneNumber", DateTime.Now , "testCpf" );

            user.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Invalid Email. Email is required!");
        }
        // Password test
        [Fact]
        public void WhenPassword_IsEmptyOrNullDomain_ShouldReturnDomainException()
        {
            Action user = () => new User("testName", "testEmail", "", "testPhoneNumber", DateTime.Now , "testCpf" );

            user.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Invalid Password. Password is required!");
        }
        // Phone Number test
        [Fact]
        public void WhenPhoneNumber_IsEmptyOrNullDomain_ShouldReturnDomainException()
        {
            Action user = () => new User("testName", "testEmail", "testPassword", "", DateTime.Now , "testCpf" );

            user.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Invalid Phone Number. Phone Number is required!");
        }
        // Birth Date test
        [Fact]
        public void WhenBirthDate_IsEmptyOrNullDomain_ShouldReturnDomainException()
        {
            Action user = () => new User("testName", "testEmail", "testPassword", "testPhoneNumber", null , "testCpf" );

            user.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Invalid Birth Date. Birth Date is required!");
        }
        // CPF test
        [Fact]
        public void WhenCPF_IsEmptyOrNullDomain_ShouldReturnDomainException()
        {
            Action user = () => new User("testName", "testEmail", "testPassword", "testPhoneNumber", DateTime.Now , "" );

            user.Should().Throw<DomainExceptionValidation>()
            .WithMessage("Invalid CPF. CPF is required!");
        }
        [Fact]
        public void WhenCPF_LenghtMoreThanDomain_ShouldReturnDomainException()
        {
            Action user = () => new User("testName", "testEmail", "testPassword", "testPhoneNumber", DateTime.Now , "testCpf" );

            user.Should().Throw<DomainExceptionValidation>()
            .WithMessage("CPF must have 11 characteres.");
        }
    }
}
