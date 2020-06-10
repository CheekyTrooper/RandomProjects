using System;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Continious loop to keep console open and to re-iterate once a string has been converted.
            while (true)
            {
                Console.WriteLine("Please input your string to reverse.");

                //Read the input text in the console and pass to the originalString variable.
                string originalString = Console.ReadLine();

                //Check if the originalString is populated, if not the user has pressed enter without populating.
                if (originalString != "")
                {
                    //Read out the string returned from the ReverseString method.
                    Console.WriteLine($"Your reverse string is: \n{ReverseString(originalString)}");
                }
                else
                {
                    //If the user has not 
                    Console.WriteLine("No text input");
                }
                //To add space for readability.
                Console.WriteLine("\n");
            }
        }

        private static string ReverseString (string s)
        {
            //Split out the string into a character array eg.{test -> t,e,s,t}
            char[] charArray = s.ToCharArray();
            //Reverse the charArray and save it back to charArray eg.{t,e,s,t = t,s,e,t}
            Array.Reverse(charArray);
            //return the new combined string
            return new string(charArray);
        }
    }
}
