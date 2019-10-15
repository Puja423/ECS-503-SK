using System;
using System.Collections.Generic;
using System.Xml;

namespace SK.StudentTranscript
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = new List<string>();
            List<int> grades = new List<int>();
            List<int> credits = new List<int>();
            
            courses.Add("test");
            grades.Add(1);
            credits.Add(10);
            
            while (true)
            {
                Console.WriteLine("Ju lutem shkruani emrin e lendes, ose shkruani X per te vazhduar!");
                string courseName = Console.ReadLine();
                if (courseName == "X" || courseName == "x")
                    break;

                courses.Add(courseName);

                Console.WriteLine("Ju lutem shkruani numrin e kredive per kete lende!");
                int credit = Convert.ToInt32(Console.ReadLine());
                credits.Add(credit);

                Console.WriteLine("Ju lutem shkruani noten per kete lende!");
                int grade = Convert.ToInt32(Console.ReadLine());
                grades.Add(grade);
            }
            
            Console.WriteLine("        TRANSKRIPTA E STUDENTIT");
            Console.WriteLine("=======================================");
            Console.WriteLine("| LENDA \t\t KREDITE \t NOTA");
            Console.WriteLine("=======================================");
            double shumaKredive = 0;
            double shumaNotave = 0;
            for (var i = 0; i<courses.Count; i++)
            {
                Console.WriteLine(courses[i] + "\t\t" + credits[i] + "\t" + grades[i]);
                shumaKredive += credits[i];
                shumaNotave += credits[i] * grades[i];
            }
            double gpa = shumaNotave / shumaKredive;

            Console.WriteLine("=======================================");
            Console.WriteLine("Nota mesatare: " + gpa.ToString("0.00"));
            Console.ReadLine();
        }
    }
}






