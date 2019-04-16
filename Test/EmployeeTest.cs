// <copyright file="EmployeeTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ScreenPlay.Test
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using ScreenPlay.Tasks;

    /// <summary>
    /// Employe.
    /// </summary>
    [TestFixture]
    public class EmployeeTest : BaseTest
    {
        /// <summary>
        /// Ini.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            Login.As(this.Driver, "admin", "admin123");
        }

        /// <summary>
        /// Add.
        /// </summary>
        [Test]
        public void AddEmployeeTest()
        {
            AddEmployee.WithTheData(this.Driver, "Juan", "juan@gmail.com", "MTV", "598752022");
            Assert.IsTrue(AcceptAlert.Success(this.Driver));
        }
    }
}
