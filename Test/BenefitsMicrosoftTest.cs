using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ScreenPlay.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlay.Test
{
    [TestFixture]
    class BenefitsMicrosoftTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            //this.Url="https://my.visualstudio.com/benefits";
            Driver.Url="https://my.visualstudio.com/benefits";
            //SetUpBase("https://my.visualstudio.com/benefits");
            //Driver.Url="https://my.visualstudio.com/benefits";
        }

        [Test]
        public void LinkedinSearch()
        {
            LoginOutlook.As(Driver, "@hotmail.com", "*");
            SelectBenefLinkedin.SelectBenef(Driver);
            System.Threading.Thread.Sleep(15000);
        }
    }
}
