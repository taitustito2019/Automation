// <copyright file="DateNow.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ScreenPlay.Actions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using OpenQA.Selenium;

    /// <summary>
    /// Obtein date.
    /// </summary>
    public class DateNow
    {
        /// <summary>
        /// Date.
        /// </summary>
        /// <returns>Date now.</returns>
        public static string Date()
        {
            DateTime dt = DateTime.Now;
            return string.Format("{0:M.d.yyyy}", dt);
        }
    }
}
