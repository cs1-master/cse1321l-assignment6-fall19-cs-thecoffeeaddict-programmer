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

        public Pacman() //default constructor, starts pacman off in the center of the screen
        {
            int x = 5;
            int y = 5;
        }

        public void locator()
        {
            Console.WriteLine("Current location -\tX: " + x + "\tY: " + y);
            Console.WriteLine("(U)p, (D)own, (L)eft, (R)ight, or (Q)uit: ");
            char answer = Console.ReadLine();
            
            switch (answer)
            {
                case 'U':
                    pac.Up();
                    break;
                case 'D':
                    pac.Down();
                    break;
                case 'L':
                    pac.Left();
                    break;
                case 'R':
                    pac.Right();
                    break;
            }
        }

        //Method that will create our object of pac-man and will handle input and output of our program.
        public static void Main(String[] args)
        {
            //Method that will create our pac-man object in the middle of the screen and keep updating its position until the player wants to stops.
            // Create our pac-man object in the middle of the screen and keep updating its position until the player wants to stops.

            //1. create a pac-man object.
            //2. update its position based on the user input.
            //3. repeat step 2 until the player inputs 'Q'.

            Pacman pac = new Pacman();
            Console.WriteLine(pac);

        }


    }
}
