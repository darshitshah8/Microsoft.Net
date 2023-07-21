using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingModel
{
    public class AgeCheck
    {
        public string CheckTheAge(int currentAge)
        {
            string output = " ";
            if (currentAge < 18)
            {
                output = $"You can not Drive";
            }
            else 
            { 
                output = $"You can Drive";
            }
            return output ;
        }
    }
}
