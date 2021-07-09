using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        public Human playerOne = new Human();
        public Ai playerTwo = new Ai();
        public int scoreToWin = 2;

        public Game()
        {
            playerOne.ChooseName();
            Console.WriteLine("How many rounds to win?");
            scoreToWin = Int32.Parse(Console.ReadLine());
            DisplayGestures(); 
            Console.WriteLine("Starting game.");
            while(playerOne.score < scoreToWin && playerTwo.score < scoreToWin)
            {
                GameRound();
            }
            if(playerOne.score == scoreToWin)
            {
                Console.WriteLine($"{playerOne.name} wins!");
            }
            else
            {
                Console.WriteLine($"{playerTwo.name} wins!");
            }
        }

        public void DisplayGestures()
        {
           foreach(Gesture gesture in playerOne.gestureOptions)
            {
                Console.WriteLine(gesture.name + " " + gesture.attackWords[0] + " " + gesture.beats[0] + " or " + gesture.attackWords[1] + " " + gesture.beats[1] + ".");
            }
        }

        public void GameRound()
        {
            playerOne.gesture.name = "";
            playerTwo.gesture.name = "";
            while (playerOne.gesture.name == playerTwo.gesture.name)
            {
                Gesture playerOneChoice = playerOne.ChooseGesture();
                Gesture playerTwoChoice = playerTwo.ChooseGesture();
                if (playerOneChoice.name == playerTwoChoice.name)
                {
                    Console.WriteLine("Both players chose the same gesture. Try again.");
                }
            }
            Console.WriteLine($"{playerOne.name} chose {playerOne.gesture.name}. {playerTwo.name} chose {playerTwo.gesture.name}.");
            if (Array.Exists(playerTwo.gesture.beats, element => element == playerOne.gesture.name))
            {
                playerTwo.score += 1;
                int attackWordIndex = Array.FindIndex(playerTwo.gesture.beats, item => item == playerOne.gesture.name);
                string attackWord = playerTwo.gesture.attackWords[attackWordIndex];
                Console.WriteLine($"{playerTwo.gesture.name} {attackWord} {playerOne.gesture.name} - {playerTwo.name} wins the round!");
            }
            else
            {
                playerOne.score += 1;
                int attackWordIndex = Array.FindIndex(playerOne.gesture.beats, item => item == playerTwo.gesture.name);
                string attackWord = playerOne.gesture.attackWords[attackWordIndex];
                Console.WriteLine($"{playerOne.gesture.name} {attackWord} {playerTwo.gesture.name} - {playerOne.name} wins the round!");
            }
            Console.WriteLine($"{playerOne.name} score: {playerOne.score}\n" +
                $"{playerTwo.name} score: {playerTwo.score}\n" +
                $"Score needed to win: {this.scoreToWin}");
        }
    }
}
