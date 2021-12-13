using System;
using System.IO;

namespace MyLs
{
    class Program
    {
        static void Main(string[] args)
        {
            var dirs = Directory.GetDirectories(Directory.GetCurrentDirectory());
            foreach (var direct in dirs) Console.WriteLine(direct);

            string directories = Directory.GetCurrentDirectory();

            string[] files = Directory.GetFileSystemEntries(directories);
            foreach (string name in files)
            {
                if(File.GetAttributes(name) == FileAttributes.Directory)
                {
                    Console.WriteLine("<DIR>" + '\t' + File.GetCreationTime(name)+ '\t' + Path.GetFileName(name));
                }
                else
                {
                    Console.WriteLine("<File>" + '\t' + File.GetCreationTime(name) + '\t' + Path.GetFileName(name));
                }
            }


        }
    }
}
