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

        public static void ReverseNumber()
        {
            Console.WriteLine("Enter a No. to reverse");
            int Number = int.Parse(Console.ReadLine());
            int Reverse = 0;
            while (Number > 0)
            {
                int remainder = Number % 10;
                Reverse = (Reverse * 10) + remainder;
                Number = Number / 10;
            }
            Console.WriteLine("Reverse No. is {0}", Reverse);
            Console.ReadLine();
        }
    }
}
