using System;
using System.Collections.Generic;
using System.Text;

namespace REIZTECK_Assignment
{
    class AssignmentOne
    {
        int hour, munite;//variables to store input values
        double resultDegree;//variable to store degree result
        string proceed; // variable to check whether the user proceed with the program or exit
        bool invalidHour = false, invalidMunite = false;
        public static void TaskOne()
        {
            //variables to store input values
            int hour, munite;
            //variable to store degree result
            double resultDegree;
            // variable to check whether the user proceed with the program or exit
            string proceed; 
            bool invalidHour = false, invalidMunite = false;

            //to make the program loop until the user want to exit
            do
            {
                Console.WriteLine("A program to Calculate lesser angle in degrees between hours and minutes");

                //check the validity of the hour input and iterate until valid input is entered
                do
                {
                    //reset the variable input in every iteration
                    invalidHour = false;
                    Console.WriteLine("Please Enter Hour");
                    //to convert the input string into int value
                    hour = int.Parse(Console.ReadLine());

                    if (hour < 0 || hour > 12)
                    {
                        Console.WriteLine("Invalid hour input");
                        invalidHour = true;
                    }

                } while (invalidHour);

                //check the validity of the munite input and iterate until valid input is entered
                do
                {
                    //reset the variable input in every iteration
                    invalidMunite = false;
                    Console.WriteLine("Please Enter Munite");
                    munite = int.Parse(Console.ReadLine());

                    if (munite < 0 || munite > 60)
                    {
                        Console.WriteLine("Invalid munite input");
                        invalidMunite = true;
                    }
                } while (invalidMunite);
                //call a method to calculate and store the result into the variable 
                resultDegree = CalculateDegree(hour, munite);
                Console.WriteLine("The lesser angle in degree between {0} hour and {1} munite is {2} degree", hour, munite, resultDegree);
                Console.WriteLine("Do you want to continue degree calculation y/n");
                proceed = Console.ReadLine();
                invalidHour = invalidMunite = false;
            }
            while (proceed == "y");

        }
        public static double CalculateDegree(int hour, int munite)
        {
            //variables to store calculated result
            double hourDegree, muniteDegree, degreeResult;
            //a formula to calculate the degree of a given hour
            hourDegree = (hour + (munite / 60)) * 30; 
            //a formula to calculate the degree of a given munite
            muniteDegree = munite * 6;
            //use absolute value of the result to eliminate negative value
            degreeResult = Math.Abs(hourDegree - muniteDegree);
            //to find the lesser angle based on calculated degree result
            if (degreeResult < 180)
                return degreeResult;
            else
                return 360 - degreeResult;
        }

    }
}

