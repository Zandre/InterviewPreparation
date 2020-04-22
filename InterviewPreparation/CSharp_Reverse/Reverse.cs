using System;

namespace InterviewPreparation.CSharp_Reverse
{
    public class Reverse
    {
        public static void ReverseString()
        {
            Console.WriteLine("Enter a string to reverse");
            string s = Console.ReadLine();
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            
            //Displaying the reverse word  
            Console.WriteLine($"Reverse word is {new string(array)}");
            Console.ReadLine();
        }
    }
}
