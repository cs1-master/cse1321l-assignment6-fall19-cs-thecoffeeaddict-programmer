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

            int R, G, B;
            ColorEditor userColor = new ColorEditor();
            do
            {
                Console.WriteLine("Do you want to:\n1) Increase Red, 2) Decrease Red\n3) Increase Green, 4) Decrease Green\n5) Increase Blue, 6) Decrease Blue\n7) Print the inverse, or 8) Quit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) 
                {
                    case 1: // increase red
                        if (R >= 0 && R <= 255)
                        {
                            R = userColor.IncreaseRed(R);
                            userColor.toString(R, G, B);
                        }
                        else if (R > 255) 
                        {
                            Console.WriteLine("Red cannot increase further.");
                            userColor.toString(R, G, B);
                        }
                        break;
                    case 2: // decrease red
                        if (R >= 0 && R <= 255)
                        {
                            R = userColor.DecreaseRed(R);
                            userColor.toString(R, G, B);
                        }
                        else if (R < 0)
                        {
                            Console.WriteLine("Red cannot decrease further.");
                            userColor.toString(R, G, B);
                        }
                        break;
                    case 3: // increase green
                        if (G >= 0 && G <= 255) 
                        {
                            G = userColor.IncreaseGreen(G);
                            userColor.toString(R, G, B);
                        }
                        else if (G > 255)
                        {
                            Console.WriteLine("Green cannot increase further.");
                            userColor.toString(R, G, B);
                        }
                        break;
                    case 4: // decrease green
                        if (G >= 0 && G <= 255)
                        {
                            G = userColor.DecreaseGreen(G);
                            userColor.toString(R, G, B);
                        }
                        else if (G < 0)
                        {
                            Console.WriteLine("Green cannot decrease further.");
                            userColor.toString(R, G, B);
                        }
                        break;
                    case 5: // increase blue
                        if (B >= 0 && B <= 255)
                        {
                            B = userColor.IncreaseBlue(B);
                            userColor.toString(R, G, B);
                        }
                        else if (B > 255)
                        {
                            Console.WriteLine("Blue cannot increase further.");
                            userColor.toString(R, G, B);
                        }
                        break;
                    case 6: // decrease blue
                        if (B >= 0 && B <= 255)
                        {
                            B = userColor.DecreaseBlue(B);
                            userColor.toString(R, G, B);
                        }
                        else if (B < 0) 
                        {
                            Console.WriteLine("Blue cannot decrease further.");
                            userColor.toString(R, G, B);
                        }
                        break;
                    case 7: // print inverse
                        userColor.PrintInverse(R, G, B);
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