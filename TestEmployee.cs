using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProject
{
    class TestEmployee
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee(1001, "Scott", "Manager", 250000.00, "Sales", "Mumbai");
            Console.WriteLine("Eno:" + Emp[0]);
            Console.WriteLine("Ename:" + Emp[1]);
            Console.WriteLine("Job:" + Emp[2]);
            Console.WriteLine("Salary:" + Emp[3]);
            Console.WriteLine("Dname:" + Emp[4]);
            Console.WriteLine("Location:" + Emp[5]);

            Emp[2] = "Sr.Manager";
            Emp[3] = 2500000.00;

            Console.WriteLine("\nModified Employee");

            Console.WriteLine("Eno:" + Emp[0]);
            Console.WriteLine("Ename:" + Emp[1]);
            Console.WriteLine("Job:" + Emp[2]);
            Console.WriteLine("Salary:" + Emp[3]);
            Console.WriteLine("Dname:" + Emp[4]);
            Console.WriteLine("Location:" + Emp[5]);



            Console.WriteLine("\nModified Employee");
            // we r giving in lower case name or dname but due to toUpper() itwill work
            Console.WriteLine("Eno:" + Emp["Eno"]);
            Console.WriteLine("Ename:" + Emp["ename"]);
            Console.WriteLine("Job:" + Emp["Job"]);
            Console.WriteLine("Salary:" + Emp["Salary"]);
            Console.WriteLine("Dname:" + Emp["dname"]);
            Console.WriteLine("Location:" + Emp["Location"]);

            Emp["Job"] = "Head";
            Emp[3] = 2500000.00;

            Console.WriteLine();
            Console.WriteLine("Eno:" + Emp["Eno"]);
            Console.WriteLine("Ename:" + Emp["ename"]);
            Console.WriteLine("Job:" + Emp["Job"]);
            Console.WriteLine("Salary:" + Emp["Salary"]);
            Console.WriteLine("Dname:" + Emp["dname"]);
            Console.WriteLine("Location:" + Emp["Location"]);
            Console.ReadLine();
        }
    }
}
