using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello guys!");
            Teacher teacher = new Teacher();
            string input;


            //Input
            Console.WriteLine("Enter Teacher ID: ");
            input = Console.ReadLine();
            teacher.ID = Convert.ToInt32(input);

            Console.WriteLine("Enter Teacher name: ");
            teacher.Name = Console.ReadLine();

            Console.WriteLine("Enter Teacher class name: ");
            teacher.classNAME = Console.ReadLine();

            Console.WriteLine("Enter section ID: ");
            teacher.Section = Console.ReadLine()[0];


            //Output
            String content = "Teacher's infomation:\nID: " + teacher.ID + "\nName: " + teacher.Name + "\nClass name:" + teacher.classNAME + "\nSection ID: " + teacher.Section;
            Console.WriteLine(content);

            //Saving output to a text file
            saveContent(content);
        }

        public static void saveContent(string content)
        {
            string direc = Directory.GetCurrentDirectory();
            Console.WriteLine("Directory: " + direc);

            string filename = "Data.txt";

            //Checking if the file exist or not
            if (File.Exists(filename))
            {
                Console.WriteLine("File exist");
                File.WriteAllText(filename, content);
            }
            else
            {
                Console.WriteLine("File doen not exist");
                File.WriteAllText(filename, content);
            }
        }

        public class Teacher
        {
            int id;
            string name;
            string className;
            char section;
                
            public int ID
            {
                set {
                    //ID should be between 0-100
                    if(value > 100 || value < 0)
                    {
                        Console.WriteLine("Error! Wrong ID input");
                    }
                    else { this.id = value; }
                    
                     }
                get
                {
                    return this.id;
                }
            }

            public string Name { 
                set { this.name = value; }
                get { return this.name; }
            }

            public string classNAME
            {
                set { this.className = value; }
                get {return this.className; }
            }

            public char Section
            {
                set { this.section = value; }
                get { return this.section; }
            }
        }
    }
}
