using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationLibrary
{
    public class CalculationModule
    {
        public int Add(int num1,int num2)
        {
            int output = num1 + num2;
            return output;
        }
        public int Sub(int num1,int num2) 
        {
            int output = num1 - num2;
            return output;
        }
        public int Mul(int num1,int num2) 
        {
            int output = num1 * num2;
            return output;
        }
        public double Div(double num1, double num2)
        {
            double output = 0;
            if (num2 != 0)
            {
                output = num1 / num2;
            }                               
            return output;
        }


    }
}
