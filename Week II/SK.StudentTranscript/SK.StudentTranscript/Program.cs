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
            grades.Add(10);
            credits.Add(10);
            
            while (true)
            {
                Console.WriteLine("Ju lutem shkruani emrin e lendes, ose shkruani X per te vazhduar!");
                string courseName = Console.ReadLine();
                if (courseName == "X" || courseName == "x")
                    break;

                courses.Add(courseName);

                Console.WriteLine("Ju lutem shkruani numrin e kredive per kete lende!");
                while (true)
                {
                    int credit;
                    if (int.TryParse(Console.ReadLine(), out credit) && credit >= 1 && credit <= 10)
                    {
                        credits.Add(credit);
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ju lutemi jepeni nje vlere prej 5-10!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                
                Console.WriteLine("Ju lutem shkruani noten per kete lende!");

                while (true) 
                {
                    string _grade = Console.ReadLine();
                    
                    switch (_grade.ToLower())
                    {
                        case "in":
                            _grade = "3";
                            break;
                        case "nr":
                            _grade = "4";
                            break;
                    }

                    int grade;
                    if (int.TryParse(_grade, out grade) && (grade >= 3 && grade <= 10))
                    {
                        grades.Add(grade);
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ju lutemi jepeni nje vlere prej 5-10!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }

            Console.WriteLine("        TRANSKRIPTA E STUDENTIT");
            Console.WriteLine("=======================================");
            Console.WriteLine("| LENDA \t\t KREDITE \t NOTA");
            Console.WriteLine("=======================================");
            double shumaKredive = 0;
            double shumaNotave = 0;
            for (var i = 0; i<courses.Count; i++)
            {
                switch (grades[i])
                {
                    case 3:
                        Console.WriteLine(courses[i] + "\t\t" + credits[i] + "\t" + "IN" );
                        break;
                    case 4:
                        Console.WriteLine(courses[i] + "\t\t" + credits[i] + "\t" + "NR" );
                        break;
                    default:
                        Console.WriteLine(courses[i] + "\t\t" + credits[i] + "\t" + grades[i] );
                        break;
                }
                
                
                if (!(grades[i] >= 3 && grades[i] <= 5))  {
                    shumaKredive += credits[i];
                    shumaNotave += credits[i] * grades[i];
                }
            }
            double gpa = shumaNotave / shumaKredive;

            Console.WriteLine("=======================================");
            Console.WriteLine("Nota mesatare: " + gpa.ToString("0.00"));
        }
    }
}






