/* Class: CSE 1321L
   Section: 
   Term: Fall 2019
   Instructor: 
   Name: 
   Assignment: 06
*/

using System;

//Class to create new colors using RGB
public class ColorEditor
{
    //Class variables that are used to hold the current color values.
    private int red;
    private int green;
    private int blue;
    private int lumi; //luminance


            //Constructor that will initialize the value of colors that are passed as the parameter
            public ColorEditor()
            {
                red = 254;
                green = 2;
                blue = 100;
            }
            public int getRed()
            {
                return red;
            }
            public int setRed(int red)
            {
                this.red = red;
                return red;
            }
            public int getGreen()
            {
                return green;
            }
            public int setGreen(int green)
            {
                this.green = green;
                return green;
            }
            public int getBlue()
            {
                return blue;
            }
            public int setBlue(int blue)
            {
                this.blue = blue;
                return blue;
            }

            //Methods to increase or decrease the red, green and blue components
            public int IncreaseRed(int red)
            {
                red += 1;
                return red;
            }
            public int DecreaseRed(int red)
            {
                red -= 1;
                return red;
            }
            public int IncreaseGreen(int green)
            {
                green += 1;
                return green;
            }
            public int DecreaseGreen(int green)
            {
                green -= 1;
                return green;
            }
            public int IncreaseBlue(int blue)
            {
                blue += 1;
                return blue;
            }
            public int DecreaseBlue(int blue)
            {
                blue -= 1;
                return blue;
            }

            //Method to calculate and print the inverse color
            public void PrintInverse(int red, int green, int blue)
            {
                int invR, invG, invB;
                invR = 255 - red;
                invG = 255 - green;
                invB = 255 - blue;
                Console.WriteLine("Inverse is R: " + invR + "\tG: " + invG + "\tB: " + invB);
            }

            //Method that calculates the Luminance and returns the string representing the current values for each component
            public void ToString(int red, int green, int blue)
            {
                double lumi = (0.2126 * red) + (0.7512 * green) + (0.0722 * blue);
                Console.WriteLine("R: " + red + "\tG: " + green + "\tB: " + blue + "\tL: " + lumi);
            }
}