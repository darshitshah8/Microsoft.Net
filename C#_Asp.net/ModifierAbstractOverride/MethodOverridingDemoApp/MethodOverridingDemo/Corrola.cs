using System;

namespace MethodOverridingDemo
{
    public class Corrola : Car
    {
        public override void SetClock()
        {
            Console.WriteLine("Fiddle with Corrola Clock");
        }
    }
}
