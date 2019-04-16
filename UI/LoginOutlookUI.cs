// <copyright file="LoginOutlookUI.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ScreenPlay.UI
{
    using OpenQA.Selenium;

    /// <summary>
    /// Map login Outlook.
    /// UserInput.
    /// PassWordInput.
    /// LoginButton.
    /// OptionNo.
    /// </summary>
    internal partial class LoginOutlookUI
    {
        private static By userInput = By.CssSelector("input[name='loginfmt']");
        private static By passWordInput = By.CssSelector("input[name='passwd']");
        private static By loginButton = By.CssSelector("input[type='submit']");
        private static By optionNo = By.CssSelector("input[value = 'No']");

        /// <summary>
        /// GetUserInput.
        /// </summary>
        /// <returns>userInput.</returns>
        public static By GetUserInput()
        {
            return userInput;
        }

        /// <summary>
        /// SetUserInput.
        /// </summary>
        /// <param name="value">userInput.</param>
        public static void SetUserInput(By value)
        {
            userInput = value;
        }

        /// <summary>
        /// GetPassWordInput.
        /// </summary>
        /// <returns>passWordInput.</returns>
        public static By GetPassWordInput()
        {
            return passWordInput;
        }

        /// <summary>
        /// SetPassWordInput.
        /// </summary>
        /// <param name="value">passWordInput.</param>
        public static void SetPassWordInput(By value)
        {
            passWordInput = value;
        }

        /// <summary>
        /// GetLoginButton.
        /// </summary>
        /// <returns>loginButton.</returns>
        public static By GetLoginButton()
        {
            return loginButton;
        }

        /// <summary>
        /// SetLoginButton.
        /// </summary>
        /// <param name="value">loginButton.</param>
        public static void SetLoginButton(By value)
        {
            loginButton = value;
        }

        /// <summary>
        /// GetOptionNo.
        /// </summary>
        /// <returns>optionNo.</returns>
        public static By GetOptionNo()
        {
            return optionNo;
        }

        /// <summary>
        /// SetOptionNo.
        /// </summary>
        /// <param name="value">optionNo.</param>
        public static void SetOptionNo(By value)
        {
            optionNo = value;
        }
    }
}
