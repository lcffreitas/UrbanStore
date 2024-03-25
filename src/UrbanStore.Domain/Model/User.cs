using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanStore.Domain.Entities;
using UrbanStore.Domain.Validations;

namespace UrbanStore.Domain.Model
{
    public sealed class User : EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string CPF { get; set; }

        public User(string name, string email, string password, string phoneNumber, DateTime birthDate, string cpf)
        {
            ValidateAndSetValues(name, email, password, phoneNumber, birthDate, cpf);
        }
        private void ValidateAndSetValues(string name, string email, string password, string phoneNumber, DateTime birthDate, string cpf)
        {
            ValidateName(name);
            ValidateEmail(email);
            ValidatePassword(password);
            ValidatePhoneNumber(phoneNumber);
            ValidateBirthDate(birthDate);
            ValidateCPF(cpf);

            Name = name;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            BirthDate = birthDate;
            CPF = cpf;
        }
        private void ValidateName(string name)
        {
            DomainExceptionValidation.ExceptionHandler(string.IsNullOrEmpty(name), "Invalid Name. Name is required!");
        }
        private void ValidateEmail(string email)
        {
            DomainExceptionValidation.ExceptionHandler(string.IsNullOrEmpty(email), "Invalid Email. Email is required!");
        }
        private void ValidatePassword(string password)
        {
            DomainExceptionValidation.ExceptionHandler(string.IsNullOrEmpty(password), "Invalid Password. Password is required!");
        }
        private void ValidatePhoneNumber(string phoneNumber)
        {
            DomainExceptionValidation.ExceptionHandler(string.IsNullOrEmpty(phoneNumber), "Invalid Phone Number. Phone Number is required!");
        }
        private void ValidateBirthDate(DateTime birthDate)
        {
            DomainExceptionValidation.ExceptionHandler(birthDate == null, "Invalid Birth Date. Birth Date is required!");
        }
        private void ValidateCPF(string cpf)
        {
            DomainExceptionValidation.ExceptionHandler(string.IsNullOrEmpty(cpf), "Invalid CPF. CPF is required!");
        }
    }
}
