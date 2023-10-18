using System;

class StringManipulationDebug
{
    static void Main(string[] args)
    {
        string str1 = "Hello";
        string str2 = "world";
        
        // Concatenating two strings
        string result = str1 + str2;
        Console.WriteLine("Concatenation result: " + result);

        // Finding the substring
        string sub = result.Substring(1, Math.Min(10, result.Length - 1));
        Console.WriteLine("Substring result: " + sub);

        // Changing the case
        string lowerCase = result.ToLower();
        Console.WriteLine("Lower case result: " + lowerCase);
        Console.ReadLine(); // To prevent console from closing
    }
}
