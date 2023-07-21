using BattleShipLiteLibrary;
using BattleShipLiteLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleshipLite
{
    class Program
    {
        public static void Main(string[] args)
        {
            ConsoleMessage();

            PlayerInformationModel activePlayer = CreatePlayer("player 1");
            PlayerInformationModel opponent = CreatePlayer("player 2");
            PlayerInformationModel winner = null;

            do
            {
                
                DisplayShotGrid(activePlayer);
                
                RecordPlayerShot(activePlayer, opponent);
                
                bool doseGameContinue = GameLogic.PlayerStillActive(opponent);
               
                if (doseGameContinue == true)
                {                  
                    (opponent, activePlayer) = (activePlayer, opponent);
                }
                else
                {
                    winner = activePlayer;
                }
            } while (winner == null);
            IdentifyWinner(winner);
            Console.ReadLine();
        }

        private static void ConsoleMessage()
        {
            Console.WriteLine("Welcome To Battleship Application");
            Console.WriteLine("Made By Darshit Shah");
            Console.WriteLine("Press enter to continue.......");
            Console.ReadLine();
            Console.Clear();
            
        }
        private static PlayerInformationModel CreatePlayer(string playerTitle)
        {

            PlayerInformationModel output = new PlayerInformationModel();

            Console.WriteLine($"player information for {playerTitle}");
            output.PlayerName = AskForPlayersName();    
            GameLogic.InitializeGrid(output);
            PlaceShip(output);
            Console.Clear();

            return output;
        }
        private static string AskForPlayersName()
        {
            Console.WriteLine("What is your name : ");
                string output = Console.ReadLine();
            return output;
        }
        private static void DisplayShotGrid(PlayerInformationModel activePlayer)
        {
            Console.WriteLine($"------------------- {activePlayer.PlayerName} -------------------");
            string currentRow = activePlayer.ShotGrid[0].SpotLetter;
            foreach (var gridSpot in activePlayer.ShotGrid)
            {
                if (gridSpot.SpotLetter != currentRow)
                {
                    Console.WriteLine();
                    currentRow = gridSpot.SpotLetter;
                }

                if (gridSpot.Status == GridSpotStatus.Empty)
                {
                    Console.Write($" {gridSpot.SpotLetter}{gridSpot.SpotNumber} ");
                }
                else if (gridSpot.Status == GridSpotStatus.Hit)
                {
                    Console.Write(" X  ");
                }
                else if (gridSpot.Status == GridSpotStatus.Miss)
                {
                    Console.Write(" O  ");
                }
                else
                {
                    Console.Write(" ?  ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        private static void PlaceShip(PlayerInformationModel model)
        {
            do
            {
                Console.WriteLine($"Where do you want to place your ship ? {model.ShipLocation.Count + 1} :");
                string location = Console.ReadLine();

                bool isValidShipLocation = false;

                try
                {
                    isValidShipLocation = GameLogic.PlaceShip(model, location);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error" + ex.Message);
                }
                if (isValidShipLocation == false)
                {
                    Console.WriteLine("It is not valid location , please try again.");
                }
            } while (model.ShipLocation.Count < 5);
        }
        private static string askForShot(PlayerInformationModel player)
        {
            Console.Write($" {player.PlayerName} Place your shot: ");
            string output = Console.ReadLine();
            return output;         
        }
        private static void DisplayShotResult(string row, int column, bool iSAHit)
        {
            if (iSAHit)
            {
                Console.WriteLine($"{row.ToUpper()}{column} is hit! ");
            }
            else
            {
                Console.WriteLine($"{row.ToUpper()}{column} is miss");
            }
            Console.WriteLine();
        }
        private static void RecordPlayerShot(PlayerInformationModel activePlayer, PlayerInformationModel opponent)
        {
            bool isValidShot = false;
            string row = "";
            int column = 0;
            do
            {
                string shot = askForShot(activePlayer);

                try
                {
                    (row, column) = GameLogic.SplitShotIntoRowAndColumn(shot);
                    isValidShot = GameLogic.ValidateShot(activePlayer, row, column);
                }
                catch (Exception ex)
                {
                    isValidShot = false;
                }
                if (isValidShot == false)
                {
                    Console.WriteLine("Invalid Shot , Please try again");
                }
            } while (isValidShot == false);
            // Determine Shot Result
            bool iSAHit = GameLogic.IdentifyShotResult(opponent, row, column);
            // Record Result
            GameLogic.MarkShotResult(activePlayer,row,column,iSAHit);

            DisplayShotResult(row, column, iSAHit); 
        }
        private static void IdentifyWinner(PlayerInformationModel winner)
        {
            Console.WriteLine($"Congratulation to { winner.PlayerName} for winning !! ");
            Console.WriteLine($"{winner.PlayerName} took {GameLogic.GetShotCount(winner)} shots for win");
        }





    }

}




        // Message to user when app will start "ConsoleMessages()"

        // Each player information and store into
        // PlayerInformation => PlayerName(AskForPlayersName) , ShotGrid , ShipLocation(PlaceShip)

        //Ask for player name and store in to PlayerInformationModel => PlayerName

        //Ask player for place their ship on ShotGrid

// NOTE: Library can depend on other libraries but library couldn't Depend on UI