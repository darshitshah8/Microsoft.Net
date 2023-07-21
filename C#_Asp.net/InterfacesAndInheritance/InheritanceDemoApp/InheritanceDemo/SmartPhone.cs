using System.Collections.Generic;

namespace InheritanceDemo
{
    public partial class Program
    {
        public class SmartPhone : CellPhone
        {
            public List<string> Apps { get; set; }
            public void ConnectToTheInternet() {  }
        }
    }
}
