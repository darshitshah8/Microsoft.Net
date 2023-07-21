using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardLibrary
{
    public class CalculatorModel
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }

        public double AddNumber()
        {
            double total = Num1 + Num2;
            return total;    
        }
    }
}
