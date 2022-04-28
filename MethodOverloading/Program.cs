using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Program.Add(5, 5)}");
            Console.WriteLine($"{Program.Add(5.6, 3.9)}");
            Console.WriteLine($"{Program.Add(1, 1, true)}");
        }


        public static int Add(int x, int y)
        {
            int result = int.Parse(Convert.ToString(x + y));
            return result;   
        }

        public static double Add(double x, double y)
        {
            double result = double.Parse($"{x + y}");
            return result;
        }

        public static string Add(int x, int y, bool z)
        {
            if (z == true && x + y == 1)
            {
                string result = string.Concat($"{x + y} dollar");
                return result;
                //($"{x + y} + dollars");
            }
            else if (z == true)
            {
                string result = string.Concat($"{x + y} dollars");
                return result;
                //($"{x + y} + dollar");
            }
            else
            {
                return ($"{x + y}");
            }
        }
    }
}
