﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Module7Project
{
    class Program
    {
        
        // Our project creates a simple editable student directory.

        // Directory Structure:
        //     Key  : Student Number (integer)
        //     Value: A list with this formatting -> Last Name(50 chars max), First Name(25 chars max), Major(50 chars max) 
        
        // What can be done to the Directory(dictionary)
        //     1) Add new students.
        //     2) Edit current students.
        //     3) Remove students.
        //     4) Display current students.
        //     5) Append additional information to existing students.
        //     6) Sort students by their student number.
        //     0) Exit
        
        // input controls for preventing the input of wrong data types
        static int GetInputInteger()
        {
            //Get a integer value and warn the person if the put any thing in besides a number.
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
                Console.WriteLine("What would you like to do to the Student Directory?");
                Console.WriteLine(" 1) Add a new student.");
                Console.WriteLine(" 2) Edit a student's information.");
                Console.WriteLine(" 3) Remove a student.");
                Console.WriteLine(" 4) Display current students.");
                Console.WriteLine(" 5) Add additional information to an existing student.");
                Console.WriteLine(" 6) Sort students by their student number.");
                Console.WriteLine(" 0) Exit.");
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

                    //case 2:
                        //Edit a student's information.
                        //Console.Write("Student ID Number ");
                        //studentID = GetInputInteger();
                        //break;

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
                        // Display current Student Directory
                        // Brought this code up from lower commented out section.
                        // Skip was used as part of a method by LINQ to make this new info the next index number.
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
                        // Sort students by their student number.
                        Console.Write("Sorting Directory(needs to be done).");
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

// TO DO: move all the code below into the proper switch case above
// Case 2: edit a student's information
// Case 6: Sort the keys in the dictionary.
