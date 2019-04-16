// <copyright file="EmployeeUI.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ScreenPlay.UI
{
    using OpenQA.Selenium;

    /// <summary>
    /// EmployeUi Map.
    /// </summary>
    public partial class EmployeeUI
    {
        private static By form = By.Id("formEmployee");
        private static By nameInput = By.XPath("//*[@id='formEmployee']/div[2]/div[1]/input");
        private static By emailInput = By.XPath("//*[@id='formEmployee']/div[2]/div[2]/input");
        private static By addressTextArea = By.Id("address");
        private static By phoneInput = By.Id("phone");
        private static By addButton = By.Id("addButton");

        /// <summary>
        /// form get.
        /// </summary>
        /// <returns>form.</returns>
        public static By GetForm()
        {
            return form;
        }

        /// <summary>
        /// form set.
        /// </summary>
        /// <param name="value">form.</param>
        public static void SetForm(By value)
        {
            form = value;
        }

        /// <summary>
        /// GetNameInput.
        /// </summary>
        /// <returns>nameInput.</returns>
        public static By GetNameInput()
        {
            return nameInput;
        }

        /// <summary>
        /// SetNameInput.
        /// </summary>
        /// <param name="value">nameInput.</param>
        public static void SetNameInput(By value)
        {
            nameInput = value;
        }

        /// <summary>
        /// GetEmailInput.
        /// </summary>
        /// <returns>emailInput.</returns>
        public static By GetEmailInput()
        {
            return emailInput;
        }

        /// <summary>
        /// SetEmailInput.
        /// </summary>
        /// <param name="value">emailInput.</param>
        public static void SetEmailInput(By value)
        {
            emailInput = value;
        }

        /// <summary>
        /// GetAddressTextArea.
        /// </summary>
        /// <returns>addressTextArea.</returns>
        public static By GetAddressTextArea()
        {
            return addressTextArea;
        }

        /// <summary>
        /// SetAddressTextArea.
        /// </summary>
        /// <param name="value">addressTextArea.</param>
        public static void SetAddressTextArea(By value)
        {
            addressTextArea = value;
        }

        /// <summary>
        /// GetPhoneInput.
        /// </summary>
        /// <returns>phoneInput.</returns>
        public static By GetPhoneInput()
        {
            return phoneInput;
        }

        /// <summary>
        /// SetPhoneInput.
        /// </summary>
        /// <param name="value">phoneInput.</param>
        public static void SetPhoneInput(By value)
        {
            phoneInput = value;
        }

        /// <summary>
        /// GetAddButton.
        /// </summary>
        /// <returns>addButton.</returns>
        public static By GetAddButton()
        {
            return addButton;
        }

        /// <summary>
        /// SetAddButton.
        /// </summary>
        /// <param name="value">addButton.</param>
        public static void SetAddButton(By value)
        {
            addButton = value;
        }
    }
}
