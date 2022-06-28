using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookFileIO
{
    public class FileOperations
    {
        public static void FileExists()
        {
            String path = @"C:\Users\psumi\Batch460\AddressBookProblem_FileIO\PersonInfo.txt";
            if (File.Exists(path))
                Console.WriteLine("File exists");
            else
                Console.WriteLine("File doesn't exists");
        }

        public static void ReadAllLines()
        {
            String path = @"C:\Users\psumi\Batch460\AddressBookProblem_FileIO\PersonInfo.txt";
            String[] lines;
            //C:\Users\Lenovo\source\repos\FileIODemo\Example.txt
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.WriteLine(lines[2]);
            Console.WriteLine(lines[3]);
        }
        public static void ReadAllText()
        {
            String path = @"C:\Users\psumi\Batch460\AddressBookProblem_FileIO\PersonInfo.txt";
            String lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);

        }
        public static void FileCopy()
        {
            String path = @"C:\Users\psumi\Batch460\AddressBookProblem_FileIO\PersonInfo.txt";
            String copypath = @"C:\Users\psumi\Batch460\AddressBookProblem_FileIO\PersonInfo.txt";

            File.Copy(path, copypath);
            Console.WriteLine(path, copypath);

        }
        public static void DeleteFile()
        {
            String path = @"C:\Users\psumi\Batch460\AddressBookProblem_FileIO\PersonInfo.txt";

            File.Delete(path);

        }
        public static void ReadFromStreamReader()
        {
            String path = @"C:\Users\psumi\Batch460\AddressBookProblem_FileIO\PersonInfo.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                String s = String.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void WriteUsingStreamWriter()
        {
            String path = @"C:\Users\psumi\Batch460\AddressBookProblem_FileIO\PersonInfo.txt";

            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hellow World - .Net is awesome1");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }
}