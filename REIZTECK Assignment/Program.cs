using System;

namespace REIZTECK_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice ;
            string proceed ;
            do
            {
                Console.WriteLine("Please enter your choice");
                Console.WriteLine("1. Task One");
                Console.WriteLine("2. Task Two");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                    AssignmentOne.TaskOne();
                else if (choice == 2)
                    AssignmentTwo.taskTwo();
                else
                    Console.WriteLine("Invalid input");
                Console.WriteLine("Do you want to continue with Tasks y/n");
                proceed = Console.ReadLine();
            } while (proceed == "y");
            
        }
    }
}
