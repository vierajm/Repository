using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, (string, string, string)> StudentDictionary = new Dictionary<int, (string, string, string)>();

        PopulateDictionary(StudentDictionary);

        //DisplayContents(StudentDictionary);

        Console.WriteLine("Student Dictionary Dictionary:");
        //DisplayContents(StudentDictionary);
    }

    static void PopulateDictionary(Dictionary<int, (string, string, string)> StudentDictionary)
    {
        for (int x = 1; x <= 4; x++)
        {
            // Using switch statements to Populate the Dictionary.
            switch (x)
            {
                case 1:
                    StudentDictionary.Add(1197, ("Williams", "Grace", "Biology"));
                    break;
                case 2:
                    StudentDictionary.Add(1196, ("Bennett", "Leslie", "Business Management"));
                    break;
                case 3:
                    StudentDictionary.Add(1199, ("Snowson", "Alex", "Communications"));
                    break;
                case 4:
                    StudentDictionary.Add(1198, ("Bernard", "John", "Communications"));
                    break;
            }
        }
    }


    // To display contents of the dictionary.
    //static void DisplayContents(Dictionary<int, (string Firstname, string Lastname, string Major)> StudentDictionary)
    //{
    //    foreach (KeyValuePair<string, int> kv in StudentDictionary)
    //    {
    //        Console.WriteLine(kv.Key + "; " + kv.Value);
    //    }
    //}
}