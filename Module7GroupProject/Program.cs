﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Module7Project
{
    class Program
    {
        // input controls for preventing the input of wrong data types
        static int GetInputInteger()
        {
            int value = 0;
        startInput:
            Console.WriteLine("Enter Number:");
            string input = Console.ReadLine();
            try
            {
                value = int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("That's not a number!");
                goto startInput;
            }
            return value;
        }

        static string GetInputString(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        static void Main()
        {
            // Creating a student dictionary
            Dictionary<int, List<string>> StudentDictionary = new Dictionary<int, List<string>>();
            StudentDictionary.Add(1201, new List<string> { "Williams", "Grace", "Biology" });
            StudentDictionary.Add(1199, new List<string> { "Bennett", "Leslie", "Business Management" });
            StudentDictionary.Add(1202, new List<string> { "Snowson", "Alex", "Communications" });
            StudentDictionary.Add(1198, new List<string> { "Bernard", "John", "Communications" });
            StudentDictionary.Add(1200, new List<string> { "Matos", "Shella", "Electrical Engineering" });

            while (true)
            {
                Console.WriteLine("What would you like to do to the Student Directory.");
                Console.WriteLine(" 1) Add a new student.");
                Console.WriteLine(" 2) Edit a student's information.");
                Console.WriteLine(" 3) Remove a student.");
                Console.WriteLine(" 4) Display current students.");
                Console.WriteLine(" 5) Add additional information to an existing student.");
                Console.WriteLine(" 6) Sort students by their student number.");
                Console.WriteLine(" 0) Done.");
                int choice = GetInputInteger();

                switch (choice)
                {
                    case 1:
                        // Add new student
                        Console.Write("Student ID Number: ");
                        int newStudentID = GetInputInteger();
                        string lastName = GetInputString("Enter Last Name:");
                        string firstName = GetInputString("Enter First Name:");
                        string major = GetInputString("Enter Major:");
                        StudentDictionary[newStudentID] = new List<string> { lastName, firstName, major };
                        Console.WriteLine("Student added successfully.");
                        break;

                    case 2:
                        // Edit a student's information
                        Console.Write("Enter the Student ID Number to edit: ");
                        int editStudentID = GetInputInteger();
                        if (StudentDictionary.ContainsKey(editStudentID))
                        {
                            lastName = GetInputString("Enter Last Name:");
                            firstName = GetInputString("Enter First Name:");
                            major = GetInputString("Enter Major:");
                            StudentDictionary[editStudentID] = new List<string> { lastName, firstName, major };
                            Console.WriteLine("Student information updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                        break;

                    case 3:
                        // Remove a student
                        Console.Write("Enter the Student ID Number to remove: ");
                        int idToRemove = GetInputInteger();
                        if (StudentDictionary.Remove(idToRemove))
                        {
                            Console.WriteLine("Student removed successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                        break;

                    case 4:
                        // Display current students
                        Console.WriteLine("Current student directory:");
                        foreach (var student in StudentDictionary)
                        {
                            int studentID = student.Key;
                            List<string> studentInfo = student.Value;
                            Console.WriteLine($"Student Number: {studentID}, Last Name: {studentInfo[0]}, First Name: {studentInfo[1]}, Major: {studentInfo[2]}");
                            if (studentInfo.Count > 3)
                            {
                                Console.WriteLine("Additional Information: " + string.Join(", ", studentInfo.Skip(3)));
                            }
                        }
                        break;

                    case 5:
                        // Add additional information to an existing student
                        Console.Write("Enter the Student ID Number to add additional information to: ");
                        int addInfoID = GetInputInteger();
                        if (StudentDictionary.ContainsKey(addInfoID))
                        {
                            string additionalInfo = GetInputString("Enter additional information:");
                            StudentDictionary[addInfoID].Add(additionalInfo);
                            Console.WriteLine("Information added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                        break;

                    case 6:
                        // Sort students by their student number
                        var sortedStudents = StudentDictionary.OrderBy(s => s.Key).ToDictionary(s => s.Key, s => s.Value);
                        StudentDictionary = sortedStudents;
                        Console.WriteLine("Students sorted by their student number.");
                        break;

                    case 0:
                        // Exit
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 0 and 6.");
                        break;
                }
            }
        }
    }
}
