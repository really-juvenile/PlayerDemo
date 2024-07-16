
using PlayerDemo.Models;
namespace PlayerDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1;
            Player player2;
            Player player3;

            Player[] players = {
                player1= new Player(101, "Allen", 21), 
                player2= new Player(102, "Mary", 33),
                player3= new Player(103, "Arjun", 36)
            };
            Player oldest = Player.WhoIsElder(players);
            Console.WriteLine($"The person {oldest.name} with highest age {oldest.age} ");

        }
    }
}
