// <copyright file="SelectBenefLinkedin.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ScreenPlay.Tasks
{
    using OpenQA.Selenium;
    using ScreenPlay.Actions;
    using ScreenPlay.UI;

    /// <summary>
    /// Selection benef.
    /// </summary>
    public class SelectBenefLinkedin
    {
        /// <summary>
        /// Selection benef.
        /// </summary>
        /// <param name="driver">driver.</param>
        public static void SelectBenef(IWebDriver driver)
        {
            Click.On(driver, BenefitsMicrosoft.GetLinkLinkedin());
        }
    }
}
