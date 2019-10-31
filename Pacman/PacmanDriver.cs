using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    //Class that will create our object of pac-man and will handle input and output of our program.
    class PacmanDriver
    {
        
        //Method that will create our object of pac-man and will handle input and output of our program.
        public static void Main(String[] args)
        {
            PacmanMover x = new PacmanMover();

            locator();
            

            //Method that will create our pac-man object in the middle of the screen and keep updating its position until the player wants to stops.
            // Create our pac-man object in the middle of the screen and keep updating its position until the player wants to stops.

            //1. create a pac-man object.
            //2. update its position based on the user input.
            //3. repeat step 2 until the player inputs 'Q'.

            void exitSequence()
            {
                Console.WriteLine("Thanks for playing!");
            }

            void locator()
            { // while
                Console.WriteLine("Current location -\tX: " + x. + "\tY: " + y);
                Console.WriteLine("(U)p, (D)own, (L)eft, (R)ight, or (Q)uit: ");
                char answer = Convert.ToChar(Console.ReadLine());
                int numanswer = 0;
                switch (answer)
                {
                    case 'U':
                         x.Up();
                         break;
                    case 'D':
                         numanswer = 2;
                         break;
                    case 'L':
                         numanswer = 3;
                         break;
                    case 'R':
                         numanswer = 4;
                         break;
                    case 'Q':
                        exitSequence();
                        break;
                }
          




            }

            


        }


    }
}
