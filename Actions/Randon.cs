// <copyright file="Randon.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ScreenPlay.Actions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class Randon.
    /// </summary>
    public class Randon
    {
        /// <summary>
        /// Random Number.
        /// </summary>
        /// <param name="a">Param init.</param>
        /// <param name="b">Param end.</param>
        /// <returns>String.</returns>
        public string RandomNumber(int a, int b)
        {
            Random random = new Random();
            return random.Next(a, b).ToString();
        }
    }
}
