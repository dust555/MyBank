using System;
using System.Collections.Generic;

namespace DelegatePlayerStats
{

    public delegate int GetNumber(Player p);

    public class Player
    {
        public String Name { get; set; }
        public int HeadShots { get; set; }
        public int TotalScore { get; set; }
        public int TimePlayed { get; set; }


        // public static void MostTimePlayed(List<Player> playerlist){
        //     Player winner = new();
        //     int max = 0;
        //     foreach(Player p in playerlist){
        //         if(GetTimePlayed(p) > max){
        //             winner = p;
        //             max = p.TimePlayed;
        //         }
        //     }

        //     System.Console.WriteLine($"{winner.Name} is the winner");
        // }

        //  public static void MostHeadshots(List<Player> playerlist){
        //     Player winner = new();
        //     int max = 0;
        //     foreach(Player p in playerlist){
        //         if(GetHeadshots(p) > max){
        //             winner = p;
        //             max = p.TimePlayed;
        //         }
        //     }

        //     System.Console.WriteLine($"{winner.Name} is the winner");
        // }

        
        //  public static void BestScore(List<Player> playerlist){
        //     Player winner = new();
        //     int max = 0;
        //     foreach(Player p in playerlist){
        //         if(GetTotalScore(p) > max){
        //             winner = p;
        //             max = p.TimePlayed;
        //         }
        //     }

        //     System.Console.WriteLine($"{winner.Name} is the winner");
        // }

        public static void GetWinner(List<Player> playerlist, GetNumber getnum){
            Player winner = new();
            int max = 0;
            foreach(Player p in playerlist){
                if(getnum.Invoke(p) > max){
                    winner = p;
                    max = getnum.Invoke(p);
                }
            }

            System.Console.WriteLine($"{winner.Name} is the winner");
        }

        public static int GetTotalScore(Player p){
            return p.TotalScore;
        }
        public static int GetHeadshots(Player p){
            return p.HeadShots;
        }
        public static int GetTimePlayed(Player p){
            return p.TimePlayed;
        }

    }
}