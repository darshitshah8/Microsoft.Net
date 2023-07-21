using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InrterfaceHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRun> run = new List<IRun>();

            Human human = new Human();
            run.Add(human);
            Animal animal = new Animal();
            run.Add(animal);

            foreach(var item in run) 
            {
                if (run is IRun runs)
                {
                    runs.Legs();
                }
            }
        }
        
        public interface IRun
        {
            void Legs();            
        }

        public class Human : IRun
        {
            public void Legs() 
            {
                
            }
        }
        public class Animal : IRun 
        {
            public void Legs() 
            {

            }
        }
    }
}
