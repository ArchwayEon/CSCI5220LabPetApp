using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetConsoleApp;

public class ConsoleInput
{
    public static string GetString(string prompt)
    {
        string? userInput;
        Console.Write(prompt);
        userInput = Console.ReadLine();
        if (userInput == null)
        {
            userInput = "";
        }
        return userInput;
    }

    public static int GetInteger(string prompt)
    {
        string? userInput;
        do
        {
            Console.Write(prompt);
            userInput= Console.ReadLine();
            if(userInput == null)
            {
                userInput = "";
            }
            try
            {
                return Convert.ToInt32(userInput);
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter an integer value!");
            }
        }while (true);
    }
}
