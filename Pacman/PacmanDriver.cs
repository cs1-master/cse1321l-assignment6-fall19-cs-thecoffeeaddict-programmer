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
        public PacmanDriver()
        {
            int locationx = 5;
            int locationy = 5;
        }

        

        //Method that will create our object of pac-man and will handle input and output of our program.
        public static void Main(String[] args)
        {
             PacmanMover x = new PacmanMover();
             PacmanMover y = new PacmanMover();

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
            {
                Console.WriteLine("Current location -\tX: " + x + "\tY: " + y);
                Console.WriteLine("(U)p, (D)own, (L)eft, (R)ight, or (Q)uit: ");
                char answer = Convert.ToChar(Console.ReadLine());
                int numanswer = 0;
                switch (answer)
                {
                    case 'U':
                         numanswer = 1;
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
                switch (numanswer) 
                {
                    case 1:
                        x.Up();
                        break;
                    case 2:
                        x.Down();
                        break;
                    case 3:
                        y.Left();
                        break;
                    case 4:
                        y.Right();
                        break;

                }




            }

            


        }


    }
}
