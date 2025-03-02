using System;

class Program
{
    delegate int StringProcessor(string input);

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        StringProcessor countVowels = CountVowels;
        StringProcessor countConsonants = CountConsonants;
        StringProcessor getLength = GetLength;

        Console.WriteLine($"Number of vowels: {countVowels(input)}");
        Console.WriteLine($"Number of consonants: {countConsonants(input)}");
        Console.WriteLine($"String length: {getLength(input)}");
    }

    static int CountVowels(string input)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        int count = 0;
        foreach (char c in input)
        {
            if (Array.Exists(vowels, v => v == c))
                count++;
        }
        return count;
    }

    static int CountConsonants(string input)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        int count = 0;
        foreach (char c in input)
        {
            if (char.IsLetter(c) && !Array.Exists(vowels, v => v == c))
                count++;
        }
        return count;
    }

    static int GetLength(string input)
    {
        return input.Length;
    }
}
