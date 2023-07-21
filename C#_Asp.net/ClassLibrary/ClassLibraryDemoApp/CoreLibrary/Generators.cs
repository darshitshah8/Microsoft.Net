using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary
{
    public class Generators
    {
        public string WelcomeMessage(string prefix, string lastName)
        {
            return $"Welcome to the app {prefix} {lastName}";
        }
        public string FareWellMessage(string prefix, string lastName)
        {
            return $"I hope you enjoyed time with us {prefix} {lastName} , Please come back soon";
        }
    }
}
