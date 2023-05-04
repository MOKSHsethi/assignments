using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Assign7

    {


        //Task 2 



        //public static void Main(string[] args)
        //{
        //    FileStream fs = new FileStream("C:\\Users\\Moksh.Sethi\\Desktop\\file.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        //    StreamWriter streamWriter = new StreamWriter(fs);
        //    streamWriter.WriteLine("hello");
        //    streamWriter.WriteLine("my name is");
        //    streamWriter.WriteLine("Moksh Sethi");
        //    streamWriter.Close();
        //    fs.Close();


        //    fs = new FileStream("C:\\Users\\Moksh.Sethi\\Desktop\\file.txt", FileMode.Append, FileAccess.Write);
        //      streamWriter = new StreamWriter(fs);
        //    streamWriter.WriteLine("hiiii");
        //    streamWriter.WriteLine("biii");
        //    streamWriter.Close();
        //    fs.Close();

        //    fs = new FileStream("C:\\Users\\Moksh.Sethi\\Desktop\\file.txt", FileMode.Open, FileAccess.Read);
        //    StreamReader streamReader = new StreamReader(fs);   
        //    Console.WriteLine(streamReader.ReadToEnd());
        //    streamReader.Close();
        //    fs.Close();

        //    fs = new FileStream("C:\\Users\\Moksh.Sethi\\Desktop\\file.txt", FileMode.Open, FileAccess.Read);
        //    StreamReader reader = new StreamReader(fs);
        //    string one =reader.ReadLine();
        //    while(one != null)
        //    {
        //        Console.WriteLine(one);
        //        one = reader.ReadLine();
        //    }
        //    reader.Close();

        //    fs.Close();

        //}



        //task 1


        public static void Main(string[] args)
        {
            Directory.CreateDirectory("C:\\Users\\Moksh.Sethi\\Desktop\\training\\Task");
            Directory.CreateDirectory("C:\\Users\\Moksh.Sethi\\Desktop\\training\\Task\\Task1");
            Directory.CreateDirectory("C:\\Users\\Moksh.Sethi\\Desktop\\training\\Task\\Task2");

            //File.Create("C:\\Users\\Moksh.Sethi\\Desktop\\training\\Task\\Task2\\a.txt");
            //File.Create("C:\\Users\\Moksh.Sethi\\Desktop\\training\\Task\\Task2\\b.txt");

            



            string[] list = Directory.GetFiles("C:\\Users\\Moksh.Sethi\\Desktop\\training\\Task\\Task2");
            foreach (string item in list)
            {
                Console.WriteLine(item);
               Console.WriteLine( File.GetCreationTime(item));
            }

            File.WriteAllText("C:\\Users\\Moksh.Sethi\\Desktop\\training\\Task\\Task2\\a.txt", "my name is moksh");
            File.WriteAllText("C:\\Users\\Moksh.Sethi\\Desktop\\training\\Task\\Task2\\b.txt", "my name is moksh sethi");

            //File.Copy("C:\\Users\\Moksh.Sethi\\Desktop\\training\\Task\\Task2\\a.txt", "C:\\Users\\Moksh.Sethi\\Desktop\\training\\Task\\Task2\\b.txt");

            File.Delete("C:\\Users\\Moksh.Sethi\\Desktop\\training\\Task\\Task2\\a.txt");

            Directory.Delete("C:\\Users\\Moksh.Sethi\\Desktop\\training\\Task\\Task1");
            
        }
    }
}
    