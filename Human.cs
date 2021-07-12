using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        public void ChooseName()
        {
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
        }

        public override Gesture ChooseGesture()
        {
            Gesture initial = new Gesture(null, null, null);
            Gesture gesture = initial;
            while (gesture == initial)
            {
                Console.WriteLine("{0}, choose a gesture to throw.", name);
                string userChoice = Console.ReadLine().ToUpper();
                foreach (Gesture option in gestureOptions)
                {
                    if (userChoice == option.name)
                    {
                        gesture = new Gesture(option.name, option.beats, option.attackWords);
                        break;
                    }
                }
                if (gesture == initial)
                {
                    Console.WriteLine("Invalid, try again.");
                }
            }
            this.gesture = gesture;
            return gesture;
        }
    }
}
