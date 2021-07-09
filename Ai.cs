using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Ai : Player
    {
        public Ai()
        {
            this.name = "AI";
        }

        public override Gesture ChooseGesture()
        {
            Random random = new Random();
            int randomIndex = random.Next(gestureOptions.Length);
            Gesture gesture = gestureOptions[randomIndex];
            this.gesture = gesture;
            return gesture;
        }
    }
}
