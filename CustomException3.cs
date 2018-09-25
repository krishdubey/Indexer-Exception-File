using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProject
{
    class CustomException3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age <= 0)
            {
                throw new ArithmeticException();
            }
            Console.ReadLine();
        }
    }
}
