using System;
using System.Collections.Generic;

namespace DelegatePlayerStats
{



    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new();

            players.Add(new Player(){Name="p1", TimePlayed=10, HeadShots=20, TotalScore=30});
            players.Add(new Player(){Name="p2", TimePlayed=20, HeadShots=10, TotalScore=50});
            players.Add(new Player(){Name="p3", TimePlayed=30, HeadShots=30, TotalScore=60});
            
            Player.GetWinner(players, Player.GetTimePlayed);

        }
    }
}
