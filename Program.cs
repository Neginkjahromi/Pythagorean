using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            // x is chord
            // y and z are legs
            Console.WriteLine("  Choose an option number");
            Console.WriteLine();
            Console.WriteLine("             Leg");
            for (int b = 1; b <= 4; b++)
            {
                for (int a = 4; a >= b; a--)    //decreasing space
                {
                    Console.Write("  ");
                }
                for (int a = 1; a <= b; a++)   //increasing space
                {
                    Console.Write("  ");
                }
                for (int a = 4; a >= b; a--)    //decreasing triangle
                {
                    Console.Write(" #");
                }
                Console.WriteLine();
            }
            Console.WriteLine("               ^Chord");
            Console.WriteLine();
            Console.WriteLine("      1 --> Chord calculation");
            Console.WriteLine("      2 --> Leg calculation");
            Console.Write("        --> ");
            try
            {
                int selection = Convert.ToInt16(Console.ReadLine());
                if (selection == 1)
                {
                    UnknownChord();
                }
                else if (selection == 2)
                {
                    UnknownLeg();
                }
                else
                {
                    Console.WriteLine("      Enter 1 or 2");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("      Enter a number");
                throw;
            }
            static void UnknownChord()
            {
                double x = 0, y = 0, z = 0;
                Console.Write("      Enter leg 1 ---> ");
                y = Convert.ToDouble(Console.ReadLine());
                Console.Write("      Enter leg 2 ---> ");
                z = Convert.ToDouble(Console.ReadLine());
                y = Math.Pow(y, 2);
                z = Math.Pow(z, 2);
                x = y + z;
                x = Math.Sqrt(x);
                Console.WriteLine($"Chord size is {x}");
            }
            static void UnknownLeg()
            {
                double x = 0, y = 0, z = 0;
                Console.Write("      Enter chord value ---> ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("      Enter leg value ---> ");
                y = Convert.ToDouble(Console.ReadLine());
                x = Math.Pow(x, 2);
                y = Math.Pow(y, 2);
                z = x - y;
                z = Math.Sqrt(z);
                Console.WriteLine($"      Leg size is {z}");
            }
        }
    }
}