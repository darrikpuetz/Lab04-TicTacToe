using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a game.");
            StartGame();
            
        }

        public static void StartGame()
        {
            Player darrik = new Player();
            darrik.Marker = "O";
            darrik.IsTurn = true;
            darrik.Name = "Darrik";

            Player kyungrae = new Player();
            kyungrae.Marker = "X";
            kyungrae.IsTurn = false;
            kyungrae.Name = "KyungRae";

            Game game = new Game(darrik, kyungrae);
            game.Play();

        }
        // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
        // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
    }
}
