using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOfProduct
{
    public class SignChecker
    {
        public static char GetSignOfProduct(double a, double b, double c)
        {
            if (a == 0 && b > 0 && c > 0)
            {
                return '0';
            }
            if (a < 0 && b >= 0 && c >= 0)
            {
                return '-';
            }
            if (a >= 0 && b < 0 && c >= 0)
            {
                return '-';
            }
            if (a >= 0 && b >= 0 && c < 0)
            {
                return '-';
            }
            if (a < 0 && b < 0 && c < 0)
            {
                return '-';
            }
            if (a >= 0 && b >= 0 && c >= 0)
            {
                return '+';
            }
            if (a < 0 && b < 0 && c >= 0)
            {
                return '+';
            }
            if (a < 0 && b >= 0 && c < 0)
            {
                return '+';
            }
            if (a >= 0 && b < 0 && c < 0)
            {
                return '+';
            }
            else
            {
                return '-';
            }
        }
    }
}
