﻿using BattleShipLiteLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipLiteLibrary
{
    public static class GameLogic
    {
        public static void InitializeGrid(PlayerInformationModel model) 
        {
                List<string> letters = new List<string>
                {
                    "A",
                    "B",
                    "C",
                    "D",
                    "E"
                };List<int> numbers = new List<int>
                {
                    1,
                    2,
                    3,
                    4,
                    5
                };
            foreach (string letter in letters)
            {
                foreach (int number in numbers)
                {
                    AddGridSpot(model, letter, number);
                }
            }

        }
        private static void AddGridSpot(PlayerInformationModel model , string letter,int number) 
        {
            GridSpotModel spot = new GridSpotModel() 
            {
                SpotLetter = letter,
                SpotNumber  = number,
                Status = GridSpotStatus.Empty,
            };          
            model.ShotGrid.Add(spot);
        }
        public static bool PlayerStillActive(PlayerInformationModel Player)
        {
            bool isActive = false;
            foreach (var ship in Player.ShipLocation)
            {
                if (ship.Status != GridSpotStatus.Sunk)
                {
                    isActive = true;
                }
            }
            return isActive;
        }
        public static int GetShotCount(PlayerInformationModel player)   
        {
            int shotCount = 0;
            foreach (var shot in player.ShotGrid)
            {
                if (shot.Status != GridSpotStatus.Empty)
                {
                    shotCount += 1;
                }
            }
            return shotCount;
        }
        public static bool PlaceShip(PlayerInformationModel model, string location)
        {
            bool output = false;
            (string row, int column) = SplitShotIntoRowAndColumn(location);

            bool isValidLocation = ValidateGridLocation(model,row, column);
            bool isSpotOpen = ValidateShipLocation(model, row, column);

            if (isValidLocation && isSpotOpen)
            {
                model.ShipLocation.Add(
                        new GridSpotModel
                        {
                            SpotLetter = row.ToUpper(),
                            SpotNumber = column,
                            Status = GridSpotStatus.Ship
                        }
                     );
                output = true;
            }
            return output;
        }                            
        private static bool ValidateShipLocation(PlayerInformationModel model, string row, int column)
        {
            bool isValidLocation = true;
            foreach (var ship in model.ShipLocation)
            {
                if (ship.SpotLetter == row.ToUpper() && ship.SpotNumber == column)
                {
                    isValidLocation = false; 
                }
            }
            return isValidLocation; 
        }            
        private static bool ValidateGridLocation(PlayerInformationModel model, string row, int column)
        {
            bool isValidLocation =  false;
            foreach (var ship in model.ShotGrid)
            {
                if (ship.SpotLetter == row.ToUpper() && ship.SpotNumber == column)
                {
                    isValidLocation = true  ;
                }
            }
            return isValidLocation;
        }
        public static (string row, int column) SplitShotIntoRowAndColumn(string shot)
        {
            string row = "";
            int column = 0;

            if (shot.Length != 2)
            {
                throw new ArgumentException("this was an invalid shot type","shot");
            }

            char[] shotArray = shot.ToArray();

            row = shotArray[0].ToString();
            column = int.Parse(shotArray[1].ToString());

            return (row, column);
        }
        public static bool ValidateShot(PlayerInformationModel player, string row, int column)
        {
            bool isValidShot = false;
            foreach (var gridSpot in player.ShotGrid)
            {
                if (gridSpot.SpotLetter == row.ToUpper() && gridSpot.SpotNumber == column)
                {
                    if (gridSpot.Status == GridSpotStatus.Empty)
                    {
                        isValidShot = true;
                    }
                }
            }
            return isValidShot;
        }
        public static bool IdentifyShotResult(PlayerInformationModel opponent, string row, int column)
        {
            bool isAHit = false;
            foreach (var ship in opponent.ShipLocation)
            {
                if (ship.SpotLetter == row.ToUpper() && ship.SpotNumber == column)
                {
                    isAHit = true;
                    ship.Status = GridSpotStatus.Sunk;
                }
            }
            return isAHit;
        }
        public static void MarkShotResult(PlayerInformationModel player, string row, int column, bool iSAHit)
        {
            
            foreach (var gridSpot in player.ShotGrid)
            {
                if (gridSpot.SpotLetter == row.ToUpper() && gridSpot.SpotNumber == column)
                {
                    if (iSAHit)
                    {
                        gridSpot.Status = GridSpotStatus.Hit;
                    }
                    else
                    {
                        gridSpot.Status = GridSpotStatus.Miss;
                    }
                }
            }
        }
    }
}
        



// Can be
//List<string> letters = new List<string>();
//letters.Add("A");
//letters.Add("B");
//letters.Add("C");
//letters.Add("D");
//letters.Add("E");