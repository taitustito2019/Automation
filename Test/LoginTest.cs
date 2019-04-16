// <copyright file="LoginTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ScreenPlay.Test
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using ScreenPlay.Tasks;

    /// <summary>
    /// Login Test.
    /// </summary>
    [TestFixture]
    public class LoginTest : BaseTest
    {
        /// <summary>
        /// Login.
        /// </summary>
        [Test]
        public void SuccessfulLogin()
        {
            Login.As(this.Driver, "admin", "admin123");
            Assert.IsTrue(IsEmployeePresent.Form(this.Driver));
        }
    }
}
