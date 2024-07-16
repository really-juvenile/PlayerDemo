using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDemo.Models
{
    internal class Player
    {
        const int DEFAULT_AGE = 18;
        public int id { get; }
        public string name { get; }
        public int age { get; } = DEFAULT_AGE;

        


        public Player(int Id,string Name)
        {
            id = Id;
            name = Name;

        }

        public Player(int Id, string Name,int Age) : this(Id,Name)
        {
            age =Age;
        }

        public static Player WhoIsElder(Player[] players)
        {
            Player playerInUse = null;
            int max_age = DEFAULT_AGE;
            foreach(Player player1 in players)
            {
                 if(player1.age > max_age )
                {
                    playerInUse=player1;
                }               

            }
            return playerInUse;
        }

       




    }
}
