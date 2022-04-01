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
            } while (maximum < minimum);
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
            
    }
}
