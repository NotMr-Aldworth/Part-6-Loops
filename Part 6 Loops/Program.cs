using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Prompter();
            Percent();
            Random();
            OddSum();


            Console.ReadLine();
        }


        public static void Prompter()
        {
            double minimum;
            double maximum;
            double midValue;
            Console.WriteLine("Please enter a minimum value:");
            while (!Double.TryParse(Console.ReadLine(), out minimum))
                Console.WriteLine("Please enter a valid integer");
            Console.WriteLine("Please enter a maximum value");
            do
            {
                while (!Double.TryParse(Console.ReadLine(), out maximum))
                    Console.WriteLine("Please enter a valid integer");
                if (maximum < minimum)
                    Console.WriteLine("Please enter a maximum that is greater than your minimum");
            } while (maximum <= minimum);
            Console.WriteLine("Great!");
            Console.WriteLine("Please enter an integer in between your max and min value");

            do
            {
                while (!Double.TryParse(Console.ReadLine(), out midValue))
                    Console.WriteLine("Please enter a valid integer");
                if (midValue >= minimum && midValue <= maximum)
                    Console.WriteLine("Good Number");
                else
                    Console.WriteLine("Integer entered is not inbetween your max and min value");
            } while (midValue > maximum || midValue < minimum);

            
        }
        public static void Percent()
        {
            double mark;
            double markNmbr = 0;
            double goodMrk = 0;
            string done;

            Console.WriteLine("Welcome to the mark calculator!");
            Console.WriteLine("Please enter a mark for one of your classes:");

            do
            {
                Console.WriteLine("Mark:");
                while (!Double.TryParse(Console.ReadLine(), out mark))
                    Console.WriteLine("Please enter a valid mark");
                if (mark >= 0 && mark <= 50)
                    Console.WriteLine("Please enter a valid mark");
                else if (mark >= 51 && mark <= 60)
                    Console.WriteLine("At least you are passing.");
                else if (mark >= 61 && mark <= 70)
                    Console.WriteLine("Not bad.");
                else if (mark >= 71 && mark <= 80)
                    Console.WriteLine("Good Mark.");
                else if (mark >= 81 && mark <= 90)
                    Console.WriteLine("Very Good.");
                else if (mark >= 91 && mark <= 100)
                    Console.WriteLine("Superb Mark.");
                else if (mark < 0 || mark > 100)
                    Console.WriteLine("Mark is invalid");
                


                if (mark >= 0 && mark <= 100)
                    markNmbr = (markNmbr + 1);

                if (mark >= 70)
                    goodMrk = (goodMrk + 1);
                Console.WriteLine("Finished?");
                Console.WriteLine("Enter Y if done");
                Console.WriteLine("Press enter to continue");

                done = Console.ReadLine().ToLower();

            } while (done != "y");

            Console.WriteLine($"{(goodMrk / markNmbr)*100}% of your marks are above 70%");
            
        }
        public static void Random()
        {
            Random generator = new Random();
            int min;
            int max;
            int i = 0;
            Console.WriteLine("Please enter a minimum value:");
            while (!Int32.TryParse(Console.ReadLine(), out min))
                Console.WriteLine("Please enter a valid integer");
            Console.WriteLine("Please enter a maximum value");
            do
            {
                while (!Int32.TryParse(Console.ReadLine(), out max))
                    Console.WriteLine("Please enter a valid integer");
                if (max < min)
                    Console.WriteLine("Please enter a maximum that is greater than your minimum");
            } while (max <= min);
            Console.WriteLine("Great!");
            do
            {
                double middleNmbr = generator.Next(min, max);
                double deci = generator.NextDouble();
                middleNmbr = middleNmbr + deci;
                Console.WriteLine($"{middleNmbr}");
                i = i + 1;
            } while (i != 25);


        }
        public static void OddSum()
        {
            int num;
            int change = 1;
            int solid = 0;
            Console.WriteLine("Please enter a number:");
            do
            {
                
                while (!Int32.TryParse(Console.ReadLine(), out num))
                    Console.WriteLine("Invalid Input");
                if (num <= 0)
                    Console.WriteLine("Number must be larger than 0");
            } while (num <= 0);
            


            do
            {
                solid = change + solid;
                change = change + 2;
            } while (change <= num);
            Console.WriteLine($"The odd sum of your number is {solid}");


        }

    }
}
