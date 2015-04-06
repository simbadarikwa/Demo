using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
//using Demo.EmailSender;
using Moq;



namespace Demo.Test
{
    [TestFixture]
    public class CustomerTests
    {
        [TestCase(0, "Simbarashe", "", "simbadarikwa@gmail.com", "1990-01-01", 1000, 0114258968, 200, Result = false)]
        [TestCase(0, "", "Darikwa", "simbadarikwa@gmail.com", "1990-01-01", 1000, 0114258968, 200, Result = false)]
        [TestCase(0, "Simbarashe", "Darikwa", "", null, 1000, 0114258968, 200, Result = false)]
        [TestCase(0, "Simbarashe", "Darikwa", "simbadarikwa@gmail.com", "1990-01-01", 0, 0114258968, 200, Result = true)]
        [TestCase(0, "Simbarashe", "Darikwa", "simbadarikwa@gmail.com", "1990-01-01", 1000, 0, 200, Result = false)]
        [TestCase(0, "Simbarashe", "Darikwa", "simbadarikwa@gmail.com", "1990-01-01", 1000, 0114258968, 0, Result = true)]
        [TestCase(0, "Simbarashe", "Darikwa", "simbadarikwa@gmail.com", "1990-01-01", 1000, 0114258968, 200, Result = true)] 
        public bool AddCustomerTest(int id, string name, string surname, string emailAddress, DateTime dateOfBirth, Decimal creditLimit, decimal contactNo, Decimal balance)
        {
           // //create object
           // Mock<MyEmail> objEmail = new Mock<MyEmail>();
           // //Specify functions to bypass
           // objEmail.Setup(x => x.SendEmail()).Returns(true);
           //// string errMsg;
           // //Demo.MVC.Repositories.CustomerRepository obj = new Demo.MVC.Repositories.CustomerRepository();
           // //Customer customer = new Customer
           // //{
           // //    Balance = balance,
           // //    ContactNo = contactNo,
           // //    CreditLimit = creditLimit,
           // //    DateOfBirth = dateOfBirth,
           // //    EmailAddress = emailAddress,
           // //    ID = id,
           // //    Name = name,
           // //    Surname = surname
           // //};
           // //return obj.AddCustomerWithEmail(customer, objEmail.Object, out errMsg);    
            return true;
        }
    }
}

