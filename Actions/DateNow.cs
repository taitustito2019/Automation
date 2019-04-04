using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlay.Actions
{
    class DateNow
    {
        public static string Date()
        {
            DateTime dt = DateTime.Now;
            return String.Format("{0:M.d.yyyy}", dt);
        }
    }
}
