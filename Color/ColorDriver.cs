using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color
{
    //Class that will create our object color and will handle input and output of our program.
    class ColorDriver
    {

        //Method that will create our object color and will handle input and output of our program.
        public static void Main(String[] args)
        {
            // Creates a default color object, prints its values to the screen, and enables the user
            // to invoke methods to increase or decrease any color component.

            //1. Create a Color object.
            //2. Update the color values based on user input or print the inverse color.
            //3. Repeat step 2 until the user inputs 8.
            
            ColorEditor userColor = new ColorEditor();
            int choice;
            userColor.ToString(userColor.getRed(), userColor.getGreen(), userColor.getBlue());
            do
            {
               
                Console.WriteLine("Do you want to:\n1) Increase Red, 2) Decrease Red\n3) Increase Green, 4) Decrease Green\n5) Increase Blue, 6) Decrease Blue\n7) Print the inverse, or 8) Quit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) 
                {
                    case 1: // increase red
                        if (userColor.getRed() >= 0 && userColor.getRed() <= 255)
                        {
                            userColor.setRed(userColor.IncreaseRed(userColor.getRed()));
                            userColor.ToString(userColor.getRed(), userColor.getGreen(), userColor.getBlue());
                        }
                        else if (userColor.getRed() == 256) 
                        {
                            Console.WriteLine("Red cannot increase further.");
                            userColor.setRed(255);
                            userColor.ToString(userColor.getRed(), userColor.getGreen(), userColor.getBlue());
                        }
                        break;
                    case 2: // decrease red
                        if (userColor.getRed() >= 0 && userColor.getRed() <= 255)
                        {
                            userColor.setRed(userColor.DecreaseRed(userColor.getRed()));
                            userColor.ToString(userColor.getRed(), userColor.getGreen(), userColor.getBlue());
                        }
                        else if (userColor.getRed() == -1)
                        {
                            Console.WriteLine("Red cannot decrease further.");
                            userColor.setRed(0);
                            userColor.ToString(userColor.getRed(), userColor.getGreen(), userColor.getBlue());
                        }
                        break;
                    case 3: // increase green
                        if (userColor.getGreen() >= 0 && userColor.getGreen() <= 255) 
                        {
                            userColor.setGreen(userColor.IncreaseGreen(userColor.getGreen()));
                            userColor.ToString(userColor.getRed(), userColor.getGreen(), userColor.getBlue());
                        }
                        else if (userColor.getGreen() == 256)
                        {
                            Console.WriteLine("Green cannot increase further.");
                            userColor.setRed(255);
                            userColor.ToString(userColor.getRed(), userColor.getGreen(), userColor.getBlue());
                        }
                        break;
                    case 4: // decrease green
                        if (userColor.getGreen() >= 0 && userColor.getGreen() <= 255)
                        {
                            userColor.setGreen(userColor.DecreaseGreen(userColor.getGreen()));
                            userColor.ToString(userColor.getRed(), userColor.getGreen(), userColor.getBlue());
                        }
                        else if (userColor.getGreen() == -1)
                        {
                            Console.WriteLine("Green cannot decrease further.");
                            userColor.setGreen(0);
                            userColor.ToString(userColor.getRed(), userColor.getGreen(), userColor.getBlue());
                        }
                        break;
                    case 5: // increase blue
                        if (userColor.getBlue() >= 0 && userColor.getBlue() <= 255)
                        {
                            userColor.setBlue(userColor.IncreaseBlue(userColor.getBlue()));
                            userColor.ToString(userColor.getRed(), userColor.getGreen(), userColor.getBlue());
                        }
                        else if (userColor.getBlue() == 256)
                        {
                            Console.WriteLine("Blue cannot increase further.");
                            userColor.setBlue(255);
                            userColor.ToString(userColor.getRed(), userColor.getGreen(), userColor.getBlue());
                        }
                        break;
                    case 6: // decrease blue
                        if (userColor.getBlue() >= 0 && userColor.getBlue() <= 255)
                        {
                            userColor.setBlue(userColor.DecreaseBlue(userColor.getBlue()));
                            userColor.ToString(userColor.getRed(), userColor.getGreen(), userColor.getBlue());
                        }
                        else if (userColor.getBlue() == -1) 
                        {
                            Console.WriteLine("Blue cannot decrease further.");
                            userColor.setBlue(0);
                            userColor.ToString(userColor.getRed(), userColor.getGreen(), userColor.getBlue());
                        }
                        break;
                    case 7: // print inverse
                        userColor.PrintInverse(userColor.getRed(), userColor.getGreen(), userColor.getBlue());
                        break;
                    } 
            } while (choice != 8);

        if(choice == 8)
                {
                    Console.WriteLine("Thanks for playing!");
                }

    }
  }
}