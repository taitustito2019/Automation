using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlay.Actions
{
    class Randon
    {
        public string RandomNumber(int a, int b)
        {
            Random random = new Random();
            return random.Next(a, b).ToString();
        }
    }
}
