
using System.Diagnostics;


Console.WriteLine("Hello, available commands: /start /help /info /exit");


string? userName = null;

while (true)
{
    Console.Write($"{(userName == null
            ? "Write command:  "
            : $"{userName}, write command: ")}");
    string? userCommand = Console.ReadLine();

    if (userCommand == "/start")
    {
        Console.Write($"{(userName == null
            ? "Write your name: "
            : $"{userName}, write your new name: ")}");
        userName = Console.ReadLine();

    }
    else if (userCommand == "/help")
    {
        Console.WriteLine($"{(userName == null 
            ? "Available commands:"
            : $"{userName}, available commands:")}");
        Console.WriteLine("/start - start and set user name");
        Console.WriteLine("/help - view list of commands");
        Console.WriteLine("/info - version and creation date of app");
        Console.WriteLine("/echo [text] - Write to console [text]");
        Console.WriteLine("/exit - close app");
    }
    else if (userCommand == "/info")
    {
        FileVersionInfo fileVersion = FileVersionInfo.GetVersionInfo("OtusHW_1.exe");
        Console.WriteLine($"{(userName == null
            ? $"Creation date: {File.GetCreationTime(Directory.GetCurrentDirectory())} version: {fileVersion.FileVersion}"
            : $"{userName}, creation date: {File.GetCreationTimeUtc(Directory.GetCurrentDirectory())} version:  {fileVersion.FileVersion}")}");
    }
    else if (userCommand.Contains("/echo"))
    {
        string [] line = userCommand.Split();
        string echoStr = string.Join(" ", line.Skip(1));
        Console.WriteLine($"{(userName == null
            ? $"{echoStr}"
            : $"{userName}, {echoStr}")}");
    }
    else if (userCommand == "/exit")
    {
        break;
    }

}
