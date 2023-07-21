using System;

namespace MethodOverridingDemo
{
    public abstract class Car
    {
        public virtual void StartCar()
        {
            Console.WriteLine("Turn key and start car");    
        }
        public abstract void SetClock();
    }
}
