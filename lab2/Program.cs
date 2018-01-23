using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer, oddEven;
            string more;
            Console.WriteLine("Please give me a number between 1 and 100");
            integer = int.Parse(Console.ReadLine());

            while (integer > 99 || integer < 2)
            {
                Console.WriteLine("I said between 1 and 100!");
                Console.WriteLine("Please give me a number between 1 and 100");
                integer = int.Parse(Console.ReadLine());
                if (integer > 1 || integer < 100)
                {
                    continue;
                }
            }
            oddEven = integer % 2;


            if (oddEven == 1 && integer > 60)
            {
                Console.WriteLine(integer + " Odd");
            }
            else if (oddEven == 1)
            {
                Console.WriteLine(integer + " Odd");
            }
            else if (oddEven == 0 && integer < 26)
            {
                Console.WriteLine("Even and less than 25");
            }
            else if (oddEven == 0 && integer > 25 && integer < 61)
            {
                Console.WriteLine("Even");
            }
            else if (oddEven == 0 && integer > 60)
            {
                Console.WriteLine(integer + " Even");
            }
            else
            {
                Console.WriteLine("I'm Confused");
            }

            Console.WriteLine("Would you like to continue? y/n");
            more = Console.ReadLine().ToUpper();
            while (more == "Y" || more == "YES")
            {
                Console.WriteLine("Please give me a number between 1 and 100");
                integer = int.Parse(Console.ReadLine());

                while (integer > 99 || integer < 2)
                {
                    Console.WriteLine("I said between 1 and 100!");
                    Console.WriteLine("Please give me a number between 1 and 100");
                    integer = int.Parse(Console.ReadLine());
                    if (integer > 1 || integer < 100)
                    {
                        continue;
                    }
                }
                oddEven = integer % 2;


                if (oddEven == 1 && integer > 60)
                {
                    Console.WriteLine(integer + " Odd");
                }
                else if (oddEven == 1)
                {
                    Console.WriteLine(integer + " Odd");
                }
                else if (oddEven == 0 && integer < 26)
                {
                    Console.WriteLine("Even and less than 25");
                }
                else if (oddEven == 0 && integer > 25 && integer < 61)
                {
                    Console.WriteLine("Even");
                }
                else if (oddEven == 0 && integer > 60)
                {
                    Console.WriteLine(integer + " Even");
                }
                else
                {
                    Console.WriteLine("I'm Confused");
                }

                Console.WriteLine("Would you like to continue? y/n");
                more = Console.ReadLine().ToUpper();
                if (more == "N" || more == "NO")
                {
                    continue;
                }

            }
            Console.WriteLine("Goodbye");
        }
    }
}
