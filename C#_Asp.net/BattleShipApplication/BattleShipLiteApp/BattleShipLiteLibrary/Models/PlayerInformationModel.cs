using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipLiteLibrary.Models
{
    // This class holds players name , Ship locations , Shot grid 
    // Used as "AskForPlayerName()" 
    public class PlayerInformationModel
    {
        public string PlayerName{ get; set; }
        public List<GridSpotModel> ShipLocation { get; set; } = new List<GridSpotModel>(); // Ship location = 1.ship (from Enums)
        public List<GridSpotModel> ShotGrid { get; set; } = new List<GridSpotModel>(); // ShotGrid  =  0.Empty & will be 2 or 3 on shot
    }
}
