using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUnitedTesting
{
    public class ClassCalc
    {
        public int resPlus = 0;
        public int resMinus = 0;
        public int resGange = 0;
        public double resDiv = 0D;
        public void BeregnAlt(int Tal1, int Tal2)
        {  
            resPlus = Tal1 + Tal2;
            resMinus = Tal1 - Tal2;
            resGange = Tal1 * Tal2;
            resDiv = Convert.ToDouble(Tal1) / Convert.ToDouble(Tal2);

            
        }
    }
}
