using System;
using System.Collections.Generic;
using System.Text;

public static class OldPhone
{
    private static readonly Dictionary<char, string> keypad = new Dictionary<char, string>
    {
        { '1', "&'(" },
        { '2', "ABC" },
        { '3', "DEF" },
        { '4', "GHI" },
        { '5', "JKL" },
        { '6', "MNO" },
        { '7', "PQRS" },
        { '8', "TUV" },
        { '9', "WXYZ" },
        { '0', " " },
    };

    public static void Main(string[] args)
    {
        Console.WriteLine(OldPhone.OldPhonePad("33#")); // E
        Console.WriteLine(OldPhone.OldPhonePad("227*#")); // B
        Console.WriteLine(OldPhone.OldPhonePad("4433555 555666#")); // HELLO
        Console.WriteLine(OldPhone.OldPhonePad("8 88777444666*664#")); // TURING

        Console.ReadLine();
    }

    public static string OldPhonePad(string input)
    {
        if (string.IsNullOrEmpty(input) || input[^1] != '#')
            return "";

        StringBuilder result = new StringBuilder();
        string currentSequence = "";
        char previous = '\0';

        foreach (char c in input)
        {
            if (c == '#')
            {
                if (!string.IsNullOrEmpty(currentSequence))
                    result.Append(TranslateSequence(currentSequence));
                break;
            }
            else if (c == '*')
            {
                if (!string.IsNullOrEmpty(currentSequence))
                {
                    currentSequence = "";
                }
                else if (result.Length > 0)
                {
                    result.Remove(result.Length - 1, 1);
                }
            }
            else if (c == ' ')
            {
                if (!string.IsNullOrEmpty(currentSequence))
                {
                    result.Append(TranslateSequence(currentSequence));
                    currentSequence = "";
                }
            }
            else if (char.IsDigit(c))
            {
                if (currentSequence.Length > 0 && c != currentSequence[0])
                {
                    result.Append(TranslateSequence(currentSequence));
                    currentSequence = "";
                }
                currentSequence += c;
            }
        }

        return result.ToString();
    }

    private static char TranslateSequence(string sequence)
    {
        char key = sequence[0];
        if (!keypad.ContainsKey(key))
            return '?';

        string letters = keypad[key];
        int index = (sequence.Length - 1) % letters.Length;
        return letters[index];
    }
}
