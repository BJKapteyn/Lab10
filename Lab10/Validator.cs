using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Validator
    {
        public static bool YayOrNay(string YN)
        {
            if (YN == "Y")
            {
                return true;
            }
            else if (YN == "N")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please enter Y or N");
                YayOrNay(Console.ReadLine().ToUpper());
            }
            return false;
        }

        public static void DoubleInput(string dub, out double var)
        {
            try
            {
                if (Convert.ToDouble(dub) >= 0)
                {
                    var = Convert.ToDouble(dub);
                    return;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter a positive number.");
                DoubleInput(Console.ReadLine(), out var);
            }
        }
    }
}
