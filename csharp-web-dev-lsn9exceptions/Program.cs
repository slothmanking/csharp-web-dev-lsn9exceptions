using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            try
            {
                var calculator = new Calculator();
                calculator.Divide(5, 0);
            }
            catch (Exception)
            {
                Console.WriteLine("You cannot divide by zero.");
            }
            try
            {
                // Test out your CheckFileExtension() function here!
                Dictionary<string, string> students = new Dictionary<string, string>();
                students.Add("Carl", "Program.cs");
                students.Add("Brad", "");
                students.Add("Elizabeth", "MyCode.cs");
                students.Add("Stefanie", "CoolProgram.cs");

                var gradebook = new GradeBook();

                foreach (var student in students)
                {
                    //gradebook.CheckFileExtension(student.Value);
                    Console.WriteLine(gradebook.CheckFileExtension(student.Value));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Whoops");
            }

            


        }
    }
}
