using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_16
{
    static class Utility
    {
        public static int ConvertInt(string str)
        {
            int temp;
            if(int.TryParse(str, out temp))
            {
                temp = 0;
            }

            return temp;
        }
        public static double ConvertDouble(string str)
        {
            double temp;
            if (double.TryParse(str, out temp))
            {
                temp = 0;
            }

            return temp;
        }

    }
}
