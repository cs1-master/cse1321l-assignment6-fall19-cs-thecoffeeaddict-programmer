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
    int R;
    int G;
    int B;
    int L; //luminance


    //Constructor that will initialize the value of colors that are passed as the parameter
    public ColorEditor(int R, int G, int B)
    {
        R = 254;
        G = 2;
        B = 100;
    }

    //Methods to increase or decrease the red, green and blue components
    public int IncreaseRed(int R)
    {
        R += 1;
        return R;
    }
    public int DecreaseRed(int R)
    {
        R -= 1;
        return R;
    }
    public int IncreaseGreen(int G)
    {
        G += 1;
        return G;
    }
    public int DecreaseGreen(int G)
    {
        G -= 1;
        return G;
    }
    public int IncreaseBlue(int B)
    {
        B += 1;
        return B;
    }
    public int DecreaseBlue(int B)
    {
        B -= 1;
        return B;
    }

    //Method to calculate and print the inverse color
    public void PrintInverse(int R, int G, int B)
    {
        int invR, invG, invB;
        invR = 255 - R;
        invG = 255 - G;
        invB = 255 - B;
        Console.WriteLine("Inverse is R: " + invR + "\tG: " + invG + "\tB: " + invB);
    }

    //Method that calculates the Luminance and returns the string representing the current values for each component
    public string ToString(int R, int G, int B)
    {
        int L = ((int)0.2126 * R) + ((int)0.7512 * G) + ((int)0.0722 * B);
        string newColors = "R: " + R + "\tG: " + G + "\tB: " + B + "\tL: " + L;
        return newColors;
    }
}