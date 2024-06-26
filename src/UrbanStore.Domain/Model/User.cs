﻿using System;
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
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string PhoneNumber { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Cpf { get; private set; }

        public User(string name, string email, string password, string phoneNumber, DateTime birthDate, string cpf)
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
            Cpf = cpf;
        }
        private void ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name))
                DomainExceptionValidation.ExceptionHandler(true, "Invalid name. Name is required!");
            if (name.Length > 30)
                DomainExceptionValidation.ExceptionHandler(true, "Too long name.");
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
            if (string.IsNullOrEmpty(cpf))
                DomainExceptionValidation.ExceptionHandler(true, "Invalid CPF. CPF is required!");
            if (cpf.Length > 11)
                DomainExceptionValidation.ExceptionHandler(true, "CPF must have 11 characteres.");
        }
    }
}
