// <copyright file="Login.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ScreenPlay.Tasks
{
    using OpenQA.Selenium;
    using ScreenPlay.Actions;
    using ScreenPlay.UI;

    /// <summary>
    /// Login.
    /// </summary>
    public class Login
    {
        /// <summary>
        /// As.
        /// </summary>
        /// <param name="driver">driver.</param>
        /// <param name="user">user.</param>
        /// <param name="passWord">password.</param>
        public static void As(IWebDriver driver, string user, string passWord)
        {
            Enter.Text(driver, LoginUI.GetUserInput(), user);
            Enter.Text(driver, LoginUI.GetPassWordInput(), passWord);
            Click.On(driver, LoginUI.GetLoginButton());
        }
    }
}
