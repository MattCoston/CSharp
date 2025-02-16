﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace Gradebook
{
    class MainClass
    {
        

        public static void Main(string[] args)

        {
            
            //Your program should ask the user to enter a student name, or "quit"
            Console.WriteLine("Enter a students name or quit: ");
            string StudentName = Console.ReadLine();
            Dictionary<string, string[]> Gradebook = new Dictionary<string, string[]>();
            //Once the student's name and grade have been entered, you should add the name and the grades (as a single String) to a dictionary(Dictionary<String,String>)
            //Steps 1, 2 and 3 should be repeated until the user enters quit for the students name.
            //Your program should then loop through the entries in the dictionary, 

            while (StudentName.ToLower() != "quit")
            {

                Console.WriteLine("Enter students grades seperated by spaces then hit enter: ");
                string Grades = Console.ReadLine();
                Gradebook.Add(StudentName, Grades.Split(' '));
                Console.WriteLine("Enter student's name or type quit: ");
                StudentName = Console.ReadLine().ToLower();
            }

            //and print out the name of the student, their lowest, highest and average grade.

            int[] IntGradeArray;
            int LowestGrade;
            int HighestGrade;

            foreach (var i in Gradebook.Keys)
            {
                StudentName = i;
                IntGradeArray = Array.ConvertAll(Gradebook[i], Convert.ToInt32);
                LowestGrade = IntGradeArray.Min();
                HighestGrade = IntGradeArray.Max();
                double Average = IntGradeArray.Average();

                Console.WriteLine(StudentName + " ");
                Console.WriteLine(StudentName + " lowest grade is: " + LowestGrade);
                Console.WriteLine(StudentName + " highest grade is: " + HighestGrade);
                Console.WriteLine(StudentName + " average grade is: " + Average);
                Console.ReadLine();
            }

        }

    }
}

