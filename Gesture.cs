using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Gesture
    {
        public string name;
        public string beats;
        public string attackWords;

        public Gesture(string name, string beats, string attackWords)
        {
            this.name = name;
            this.beats = beats;
            this.attackWords = attackWords
        }
    }
}
