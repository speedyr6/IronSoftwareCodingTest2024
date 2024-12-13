namespace IronSoftwareCodingTest1
{
    using System;

    // This program takes on the old nokia style phone keypaD
    // Basically it takes a numbered input which represents number of presses of the keypad per number
    // and decodes it into the appropriate character text
    //
    //  Version 1.0
    //  Date: 13-Dec-2024
    //  Author: Ron Long
    //

    public class DecodeNumbers
    {

        // Function to convert mobile numeric keypad sequence into its equivalent string
        public static string decodeInput(string inputS)
        {

            // Store the mobile keypad mappings
            string[] keypad
                = { " ",    "1",    "ABC2",  "DEF3", "GHI4",
                "JKL5", "MNO6", "PQRS7", "TUV8", "WXYZ9" };

            // shows user the input string
            //            Console.WriteLine("Hello, decoding string - " + inputS + " - Please wait");

            // first handle the backspace commands if there are any
            int backspace;
            while ((backspace = inputS.IndexOf('*')) != -1)
            {
                if (backspace > 0)
                {
                    // Remove '*' and the character before it
                    inputS = inputS.Remove(backspace - 1, 2);
                    //                   Console.WriteLine("removing *");
                }
                else
                {
                    // Remove only '*' if it's the first character
                    inputS = inputS.Remove(backspace, 1);
                    //                    Console.WriteLine("removing * from first char");
                }
            }

            char[] str = inputS.ToCharArray();
            string decodedMessage = "";

            // Loop through the string str
            int i = 0;
            while (i < str.Length)
            {
                // If the current character is SPACE, then continue to the ext iteration
                if (str[i] == ' ')
                {
                    i++;
                    continue;
                }

                // Stores the number of continuous clicks
                int count = 0;

                // Iterate a loop to find the count of same characters
                while (i + 1 < str.Length
                       && str[i] == str[i + 1])
                {
                    // 1,0 - max 1 letters/key presses (for ease of program)
                    if (count == 0
                        && (str[i] == '1' || str[i] == '0'))
                        break;

                    // 2,3,4,5,6,8 - max 4 letters/key presses
                    else if (count == 3
                        && (str[i] >= '2' && str[i] <= '6' || str[i] == '8'))
                        break;

                    // 7,9 - max 5 letters/key presses
                    else if (count == 4 && (str[i] == '7' || str[i] == '9'))
                        break;
                    count++;
                    i++;

                    // Handle the end condition and exit
                    if (i == str.Length)
                        break;
                }
                // Check if the current pressed key is 7 or 9
                if (str[i] == '7' || str[i] == '9')
                {
                    //    Console.Write(keypad[str[i] - 48][count % 4]);
                    decodedMessage += keypad[str[i] - 48][count % 5];
                }
                // Else, the key pressed is either 2, 3, 4, 5, 6 or 8
                else if (str[i] == '2' || str[i] == '3' || str[i] == '4' || str[i] == '5' || str[i] == '6' || str[i] == '8')
                {
                    //      Console.Write(keypad[str[i] - 48][count % 3]);
                    decodedMessage += keypad[str[i] - 48][count % 4];
                }
                // check for # as its end of message
                else if (str[i] == '#')
                {
                    break;
                }
                // otherwise its an invalid character
                else if (str[i] == '0' || str[i] == '1')
                {
                    //    Console.Write(keypad[str[i] - 48][count % 1]);
                    decodedMessage += keypad[str[i] - 48][count % 1];
                }
                else
                {
                    //    Console.Write(" - Error input string invalid " + inputS);
                    decodedMessage = "Error: Invalid input string";
                }
                i++;
            }
            return decodedMessage;
        }
        // Driver Code
        public static void Main(string[] args)
        {

        }
    }

}