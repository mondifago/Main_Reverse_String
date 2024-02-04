using System;

namespace Reverse_String_2;

class Reverse_String_2
{
    static void Main(string[] args)
    {
        while (true)
        {
            //display message to user
            Console.WriteLine("Type in a word or sentence and it will be reversed and compared with the original to see if it matches or not");

            //accept user input 
            string userInput = Console.ReadLine();
            Console.WriteLine("\n");

            //Convert input string to characters and reverse charaters using for Loop
            char[] userInputChar = userInput.ToCharArray();
            int userInputLength = userInput.Length;

            for (var i = 0; i < userInputLength / 2; i++)
            {
                char frontLetter = userInputChar[i];
                userInputChar[i] = userInputChar[userInputLength - i - 1];
                userInputChar[userInputLength - i - 1] = frontLetter;
            }
            //convert index characters back to string and print the reversed output
            string reversedInput = new string(userInputChar);
            Console.WriteLine("Original input:\t " + userInput);
            Console.WriteLine("Reversed form: \t" + reversedInput);

            //check user input for palindromes after converting both to upper case
            string userInputInUpperCase = userInput.ToUpper();
            string reversedInputInUpperCase = reversedInput.ToUpper();

            if (userInputInUpperCase.Equals(reversedInputInUpperCase))
            {
                Console.WriteLine("It is a match!");
            }
            else
            {
                Console.WriteLine("It is not a match!");
            }
            Console.WriteLine("Press Enter to play again or any other key to exit.");
            if (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                break;
            }
            Console.WriteLine("\n");
        }
    }
}


