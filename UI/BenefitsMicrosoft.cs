// <copyright file="BenefitsMicrosoft.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ScreenPlay.UI
{
    using OpenQA.Selenium;

    /// <summary>
    /// Benef Microsoft.
    /// </summary>
    public class BenefitsMicrosoft
    {
        private static By linkLinkedin = By.CssSelector("div:nth-of-type(5) div[class='links'] >a:nth-of-type(1)");

        /// <summary>
        /// Linkedin.
        /// </summary>
        /// <returns>linkLinkedin.</returns>
        public static By GetLinkLinkedin()
        {
            return linkLinkedin;
        }

        /// <summary>
        /// SetLinkLinkedin.
        /// </summary>
        /// <param name="value">linkLinkedin.</param>
        public static void SetLinkLinkedin(By value)
        {
            linkLinkedin = value;
        }
    }
}
