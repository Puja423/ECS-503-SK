using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace SK.StudentTranscript
{
    class Program
    {
        static void Main(string[] args)
        {   
            var courses = new List<string>();
            var grades = new List<int>();
            var credits = new List<int>();

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
                    if (int.TryParse(Console.ReadLine(), out var credit) && (1 <= credit && credit <= 10))
                    {
                        credits.Add(credit);
                        break;
                    }
                    else
                        Console.WriteLine("Ju lutemi jepeni nje vlere prej 1-10!");
                }

                Console.WriteLine("Ju lutem shkruani noten per kete lende!");
                while (true) 
                {
                    var _grade = Console.ReadLine();
                    
                    switch (_grade.ToLower())
                    {
                        case "in": _grade = "3"; break;
                        case "nr": _grade = "4"; break;
                    }
                    
                    if (int.TryParse(_grade, out var grade) && (3 <= grade && grade <= 10))
                    {
                        grades.Add(grade);
                        break;
                    }
                    else
                        Console.WriteLine("Ju lutemi jepeni nje vlere prej 5-10, NR os IN!");

                }
            }

            Console.WriteLine("        TRANSKRIPTA E STUDENTIT");
            Console.WriteLine("=======================================");
            Console.WriteLine("| LENDA \t\t KREDITE \t NOTA");
            Console.WriteLine("=======================================");
            double shumaKredive = 0f;
            double totalKredit = 0f;s
            double shumaNotave = 0f;
            for (var i = 0; i<courses.Count; i++)
            {
                Console.WriteLine(courses[i] + "\t\t" + credits[i] + "\t" + UserReadableGrade(grades[i]) );

                totalKredit += credits[i];
                if (grades[i] <= 5) continue;
                
                shumaKredive += credits[i];
                shumaNotave += credits[i] * grades[i];
            }
            var gpa = (shumaKredive > 0f) ? shumaNotave / shumaKredive : 0f;

            Console.WriteLine("=====================================");
            Console.WriteLine("Credits attempted: " + totalKredit);
            Console.WriteLine("Credits awarded: " + shumaKredive);
            Console.WriteLine("Number of courses: " + courses.Count);
            Console.WriteLine("GPA: " + gpa.ToString("0.00"));
        }

        private static string UserReadableGrade(int grade)
        {
            return grade switch
            {
                3 => "IN",
                4 => "NR",
                _ => grade.ToString()
            };
        }
    }
}






