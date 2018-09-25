using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IndexerProject
{
    class FileInfoWriter1
    {
        static void Main(string[] args)
        {
            try
            {
                string s = "g:\\abc.txt";// giving file path
                FileInfo file = new FileInfo(s);//creating fileiinfo instance
                StreamWriter sw = file.CreateText();// creating file instance to write
                // writing to the file
                sw.WriteLine("This text is written to the fileby using StreamWriter class:");
                sw.WriteLine("Hello to everyone:");
                sw.WriteLine("hello to bizruntime how r u ");
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong:" + e);
            }

            Console.WriteLine("Success");
            Console.ReadLine();
        }
    }
}
