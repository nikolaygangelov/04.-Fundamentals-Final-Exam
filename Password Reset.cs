
namespace Password_Reset
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();           
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] inputParameters = command
                    .Split();
                string commandType = inputParameters[0];

                if (commandType == "TakeOdd")
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        char currentChar = text[i];
                        if (i % 2 != 0)
                        {
                            sb.Append(currentChar);
                        }

                    }
                    text = sb.ToString();
                    Console.WriteLine(text);
                }
                else if (commandType == "Cut")
                {
                    int index = int.Parse(inputParameters[1]);
                    int length = int.Parse(inputParameters[2]);
                  
                    text = text.Remove(index, length);
                    Console.WriteLine(text);

                }
                else if (commandType == "Substitute")
                {
                    string substring = inputParameters[1];
                    string substitute = inputParameters[2];

                    if (text.Contains(substring))
                    {
                        text = text.Replace(substring, substitute);
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine($"Nothing to replace!");
                    }

                }
            }

            Console.WriteLine($"Your password is: {text}");
        }
    }
}
