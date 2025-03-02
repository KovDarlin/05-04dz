using System;
using System.IO;

class Program
{
    delegate void MessageHandler(string message);

    static void Main()
    {
        MessageHandler handler = DisplayMessage;
        handler += WriteMessageToFile;

        Console.Write("Enter a message: ");
        string message = Console.ReadLine();

        handler(message);
    }

    static void DisplayMessage(string message)
    {
        Console.WriteLine($"Message: {message}");
    }

    static void WriteMessageToFile(string message)
    {
        try
        {
            string filePath = "message_log.txt";
            File.AppendAllText(filePath, message + "\n");
            Console.WriteLine("Message written to file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error writing to file: {ex.Message}");
        }
    }

}

//не працює, чому я не знаю
