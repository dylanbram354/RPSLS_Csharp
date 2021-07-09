using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        public string name;
        public int score;
        public Gesture gesture;
        public Gesture[] gestureOptions;

        public Player()
        {
            name = "";
            score = 0;
            gesture = new Gesture(null, null, null);
            gestureOptions = CreateGestureArray();
        }

        public abstract Gesture ChooseGesture();

        public Gesture[] CreateGestureArray()
        {
            Gesture rock = new Gesture("ROCK", new string[2] { "SCISSORS", "LIZARD" }, new string[2] { "crushes", "crushes" });
            Gesture scissors = new Gesture("SCISSORS", new string[2] { "PAPER", "LIZARD" }, new string[2] { "cuts", "decapitates" });
            Gesture paper = new Gesture("PAPER", new string[2] { "ROCK", "SPOCK" }, new string[2] { "covers", "disproves" });
            Gesture lizard = new Gesture("LIZARD", new string[2] {"SPOCK", "PAPER"}, new string[2] { "poisons", "eats" });
            Gesture spock = new Gesture("SPOCK", new string[2] { "SCISSORS", "ROCK" }, new string[2] { "smashes", "vaporizes" });

            Gesture[] gestureList = new Gesture[5] { rock, paper, scissors, lizard, spock };

            return gestureList;
        }

    }
}
