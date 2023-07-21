using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            List<Phone> phones = new List<Phone>();

            phones.Add(new SmartPhone());
            phones.Add(new CellPhone());
            

            foreach (var phone in phones)
            {   
                if(phone is CellPhone cell)
                {
                    cell.Carrier = "";
                }
                if(phone is SmartPhone smartphone)
                {
                    smartphone.ConnectToTheInternet();
                }
            }
        }
    }
}
