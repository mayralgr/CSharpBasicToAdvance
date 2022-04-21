using System;

namespace Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * For checked overflow, will throw an expection
             * 
            checked
            {
                byte number = 255;
                number++;

                Console.WriteLine("This is just the beggining");
                Console.WriteLine(number);
            }*/
            byte number = 2; // or use var
            int count = 10;
            var totalPrice = 20.95f;
            char character = 'a';
            string firstName = "Mosh";
            bool isWorking = true;
            Console.WriteLine(number);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(isWorking);
            Console.WriteLine("{0},{1}", isWorking, firstName);

            byte number1 = 255;

            number1 += 2;

            Console.WriteLine(number1);

        }
    }
}
