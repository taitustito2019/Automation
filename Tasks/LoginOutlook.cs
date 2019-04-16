// <copyright file="LoginOutlook.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ScreenPlay.Tasks
{
    using OpenQA.Selenium;
    using ScreenPlay.Actions;
    using ScreenPlay.UI;

    /// <summary>
    /// Login Outlook.
    /// </summary>
    public class LoginOutlook
    {
        /// <summary>
        /// As.
        /// </summary>
        /// <param name="driver">driver.</param>
        /// <param name="user">user.</param>
        /// <param name="passWord">password.</param>
        public static void As(IWebDriver driver, string user, string passWord)
        {
            Enter.Text(driver, LoginOutlookUI.GetUserInput(), user);
            Click.On(driver, LoginOutlookUI.GetLoginButton());
            System.Threading.Thread.Sleep(4000);
            Enter.Text(driver, LoginOutlookUI.GetPassWordInput(), passWord);
            Click.On(driver, LoginOutlookUI.GetLoginButton());
            Click.On(driver, LoginOutlookUI.GetOptionNo());
        }
    }
}
