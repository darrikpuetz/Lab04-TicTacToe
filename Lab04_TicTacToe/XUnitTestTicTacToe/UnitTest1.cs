using System;
using Xunit;
using static Lab04_TicTacToe.Program;
using Lab04_TicTacToe.Classes;

namespace XUnitTestTicTacToe
{
    public class UnitTest1
    {
        [Fact]
        public void AddCharacter()
        {
            Player chris = new Player();
            chris.Marker = "X";
            Player enrique = new Player();
            chris.Marker = "O";

            Game testGame = new Game(chris, enrique);
            testGame.Board.GameBoard[0, 2] = "X";
            testGame.Board.GameBoard[1, 2] = "X";
            testGame.Board.GameBoard[2, 2] = "X";
            Assert.True(testGame.CheckForWinner(testGame.Board));


        }
    }
}
