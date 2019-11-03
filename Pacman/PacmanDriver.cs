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
            PacmanMover pacman = new PacmanMover();

             do {
                    Console.WriteLine("Current location -\tX: " + x + "\tY: " + y);
                    Console.WriteLine("(U)p, (D)own, (L)eft, (R)ight, or (Q)uit: ");
                    char answer = Convert.ToChar(Console.ReadLine());

                    switch (answer)
                    {
                        case 'U':
                            pacman.Up();
                            break;
                        case 'D':
                            pacman.Down();
                            break;
                        case 'L':
                            pacman.Left();
                            break;
                        case 'R':
                            pacman.Right();
                            break;
                        case 'Q':
                            exitSequence();
                            break;
                    }
                } while (answer != 'Q');
            

            //Method that will create our pac-man object in the middle of the screen and keep updating its position until the player wants to stops.
            // Create our pac-man object in the middle of the screen and keep updating its position until the player wants to stops.

            //1. create a pac-man object.
            //2. update its position based on the user input.
            //3. repeat step 2 until the player inputs 'Q'.

            void exitSequence()
            {
                Console.WriteLine("Thanks for playing!");
            }

        }

    }
}
