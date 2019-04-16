// <copyright file="BaseTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ScreenPlay.Test
{
    using System;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    /// <summary>
    /// BaseTest.
    /// </summary>
    public abstract class BaseTest
    {
        private IWebDriver driver;
        private string url = "http://verstandqa.com/ejercicios/";

        /// <summary>
        /// Gets or sets url.
        /// </summary>
        public string Url { get => this.url; set => this.url = value; }

        /// <summary>
        /// Gets or sets driver.
        /// </summary>
        protected IWebDriver Driver { get => this.driver; set => this.driver = value; }

        /// <summary>
        /// Ini.
        /// </summary>
        [SetUp]
        public void SetUpBase()
        {
            this.Driver = new ChromeDriver();
            this.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            this.Driver.Navigate().GoToUrl(this.Url);
        }

        /// <summary>
        /// End.
        /// </summary>
        [TearDown]
        public void TearDownBase()
        {
            if (this.Driver != null)
            {
                this.Driver.Quit();
            }
        }
    }
}
