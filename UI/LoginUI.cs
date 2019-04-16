// <copyright file="LoginUI.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ScreenPlay.UI
{
    using OpenQA.Selenium;

    /// <summary>
    /// Login UI.
    /// </summary>
    public class LoginUI
    {
        private static By userInput = By.Id("user");
        private static By passWordInput = By.Id("pass");
        private static By loginButton = By.Id("loginButton");

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
    }
}
