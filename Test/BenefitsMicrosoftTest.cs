// <copyright file="BenefitsMicrosoftTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ScreenPlay.Test
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using ScreenPlay.Tasks;

    /// <summary>
    /// Benef Microsoft.
    /// </summary>
    [TestFixture]
    public class BenefitsMicrosoftTest : BaseTest
    {
        /// <summary>
        /// Ini.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            // this.Url="https://my.visualstudio.com/benefits";
            this.Driver.Url = "https://my.visualstudio.com/benefits";

            // SetUpBase("https://my.visualstudio.com/benefits");
            // Driver.Url="https://my.visualstudio.com/benefits";
        }

        /// <summary>
        /// Login Outlook.
        /// </summary>
        [Test]
        public void LinkedinSearch()
        {
            LoginOutlook.As(this.Driver, "@hotmail.com", "*");
            SelectBenefLinkedin.SelectBenef(this.Driver);
            System.Threading.Thread.Sleep(15000);
        }
    }
}
