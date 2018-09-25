using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IndexerProject
{
    class SimpleFileMove
    {
        static void Main()
        {
            //string sourceFile = @"G:\sss\krishna.txt";
            //string destinationFile = @"G:\ttt\krishna.txt";

            string sourceFile = @"G:\sss";
            

            // To move a file or folder to a new location:
           
            // File.Move(sourceFile, destinationFile);

            // To move an entire directory. To programmatically modify or combine
            // path strings, use the System.IO.Path class.
            Directory.Move(@"G:\sss", @"G:\t");
        }
    }
}

