using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IComputerController> controllers = new List<IComputerController>();

            Keyboard keyboard = new Keyboard();
            GameController gameController = new GameController();
            BetteryPoweredGameController batteryPoweredController = new BetteryPoweredGameController();
            BetteryPoweredKeyboard betteryPoweredKeyboard = new BetteryPoweredKeyboard();

            controllers.Add(keyboard);
            controllers.Add(gameController);
            controllers.Add(batteryPoweredController);
            
            
            foreach(IComputerController controller in controllers) 
            {
                if(controller is GameController gc)
                {
                    gc.CurrentKeyPressed();
                }
                if(controller is IBatteryPowered power1)
                {
                    controller.Connect();
                }
            }         

            List<IBatteryPowered> powered = new List<IBatteryPowered>();
            powered.Add(betteryPoweredKeyboard);
            powered.Add(batteryPoweredController);



            Console.ReadLine();
        }



        public interface IComputerController
        {
            void Connect(); 
            void CurrentKeyPressed();

        }
        public interface IBatteryPowered
        {
             int BatteryLevel { get; set; } 
        }
        public class Keyboard : IComputerController
        {
            public void Connect()
            {

            }
            public void CurrentKeyPressed()
            {

            }
            public string ConnectionType { get; set; }
        }
        public class BetteryPoweredKeyboard : Keyboard , IBatteryPowered
        {
            public int BatteryLevel { get; set; }
        }
        public class GameController : IComputerController , IDisposable
        {
            public void Connect()
            {
                        
            }
            public void CurrentKeyPressed()
            {

            }

            public void Dispose()
            {
                // Do whatever shutdown task needed
            }
        }                                                                       
        public class BetteryPoweredGameController : GameController , IBatteryPowered
        {
            public int BatteryLevel { get; set; }
        }
    }
}
    