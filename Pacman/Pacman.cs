﻿/* Class: CSE 1321L
   Section: W02
   Term: Fall 2019
   Instructor: Rehnuma Afrin
   Name: Michaela Jackson
   Assignment: 06
*/

/* 
 * Screen Simulator: (x,y) <--- increasing y moves player down the screen, increasing x moves player horizontally to the right
   | (0,0) | (1,0) | (2,0) | (3,0) | (4,0) | (5,0) | (6,0) | (7,0) | (8,0) | (9,0) |
   | (0,1) | (1,1) | (2,1) | (3,1) | (4,1) | (5,1) | (6,1) | (7,1) | (8,1) | (9,1) |
   | (0,2) | (1,2) | (2,2) | (3,2) | (4,2) | (5,2) | (6,2) | (7,2) | (8,2) | (9,2) |
   | (0,3) | (1,3) | (2,3) | (3,3) | (4,3) | (5,3) | (6,3) | (7,3) | (8,3) | (9,3) |
   | (0,4) | (1,4) | (2,4) | (3,4) | (4,4) | (5,4) | (6,4) | (7,4) | (8,4) | (9,4) |
   | (0,5) | (1,5) | (2,5) | (3,5) | (4,5) | (5,5) | (6,5) | (7,5) | (8,5) | (9,5) |
   | (0,6) | (1,6) | (2,6) | (3,6) | (4,6) | (5,6) | (6,6) | (7,6) | (8,6) | (9,6) |
   | (0,7) | (1,7) | (2,7) | (3,7) | (4,7) | (5,7) | (6,7) | (7,7) | (8,7) | (9,7) |
   | (0,8) | (1,8) | (2,8) | (3,8) | (4,8) | (5,8) | (6,8) | (7,8) | (8,8) | (9,8) |
   | (0,9) | (1,9) | (2,9) | (3,9) | (4,9) | (5,9) | (6,9) | (7,9) | (8,9) | (9,9) |
*/

using System;



        public class PacmanMover
        {
            //Class variables that are used to hold the current position that pac-man is in.
            private int x;
            private int y;

            //Constructor that will initialize the position of pac-man to the one that is passed in as a parameter.
            public PacmanMover()
            {
                x = 5;
                y = 5;
            }

            public int getX()
            {
                return x;
            }
            
            public int getY()
            {
                return y;
            }
            
            public int setX(int x)
            {
                this.x = x;
                return x;
            }

            public int setY(int y)
            {
                this.y = y;
                return y;
            }

            //Methods that will update pac-man's position to be one spot to the right, left, up or down.
            public int Left(int x)
            {
                //nested if statement to update player position (x <- L) and determine whether he will teleport to the right side or not
                if (x >= 0 && x <= 9)
                {
                    x --;
                }  
                else if (x == -1)
                {
                    x = 9;
                }
                return x;
            }
            public int Right(int x)
            {
                //nested if statement to update player position (x -> R) and determine whether he will teleport to the left side or not
                if (x >= 0 && x <= 9)
                {
                    x ++;
                }
                else if (x == 10)
                {
                    x = 0;
                }
                return x;
            }
            public int Up(int y)
            {
                //nested if statement to update player position (y ^ U) and determine whether he will teleport to the bottom or not
                if (y >= 0 && x <= 9) 
                {
                    y --;
                } 
                else if (y == -1)
                {
                    y = 9;   
                }
                return y;
            }
            public int Down(int y)
            {
                //nested if statement to update player position (y v D) and determine whether he will teleport to the top or not
                if (y >= 0 && y <= 9)
                {
                    y ++;
                }
                else if (y == 10)
                {
                    y = 0;
                }
                return y;
            }
        }
