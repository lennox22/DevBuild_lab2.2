using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            Console.WriteLine("Hello again");

            int myNumber = 10;
            Console.WriteLine(myNumber);

            string myName = "Lassiter";
            Console.WriteLine(myName);

            bool isTeacher = true;
            Console.WriteLine(isTeacher);

            for (int count = 0; count < 10; count++)
            {
                Console.WriteLine(count);
            }

            int height = 3;
            Console.WriteLine(height);

            if (height >= 4 && height <= 6)
            {

                Console.WriteLine("You are the right height for the game.");

            }

            else
            {
                Console.WriteLine("Sorry, you have to wait until you're older.\nYou'll have to try again later.");
            }*/

            // under 4 feet: Print out "You're not tall enough."
            //Between 4ft and 6ft including 4 and 6 print: "Enjoy the ride."
            //Greater than 6 ft: print "Sorry, youre too tall."

            // test 3, 4, 5, 6, 7

            /*int height = 3;

            if(height < 4)
            {
                Console.WriteLine("You're not tall enough.");
            }
            else if (height >= 4 && height <= 6 )
            {
                Console.WriteLine("Enjoy the Ride.");
            }
            else
            {
                Console.WriteLine("Sorry, you're too tall");
            }*/

            /*
            string name;
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(name);

            int favorite;
            Console.WriteLine("What is your favorite number?");
            favorite = Int32.Parse(Console.ReadLine());
            */

            /*
             * Enter height
             * enter width
             * calculate area, then save in variable
             * print out the area
             */

            Console.WriteLine("Please enter the height of the rectangle: ");
            double height = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the width of the rectangle: ");
            double width = Double.Parse(Console.ReadLine());
            double area = height * width;
            
            
            
            Console.WriteLine("The area of the rectangle is " + area);

        }
    }
}
