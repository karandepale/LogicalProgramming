using System;

public class StopwatchProgram
{
    private static DateTime startTime;
    private static bool isRunning = false;

    public static void Main()
    {
        Console.WriteLine("Stopwatch Program");
        Console.WriteLine("Commands:");
        Console.WriteLine("start - Start the stopwatch");
        Console.WriteLine("stop - Stop the stopwatch");
        Console.WriteLine("quit - Quit the program");

        while (true)
        {
            Console.Write("Enter a command: ");
            string command = Console.ReadLine().ToLower();

            switch (command)
            {
                case "start":
                    StartStopwatch();
                    break;
                case "stop":
                    StopStopwatch();
                    break;
                case "quit":
                    return;
                default:
                    Console.WriteLine("Invalid command! Please try again.");
                    break;
            }
        }
    }

    // Function to start the stopwatch
    public static void StartStopwatch()
    {
        if (!isRunning)
        {
            startTime = DateTime.Now;
            isRunning = true;
            Console.WriteLine("Stopwatch started.");
        }
        else
        {
            Console.WriteLine("Stopwatch is already running. Use 'stop' command to stop it.");
        }
    }

    // Function to stop the stopwatch
    public static void StopStopwatch()
    {
        if (isRunning)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            isRunning = false;
            Console.WriteLine("Stopwatch stopped.");
            Console.WriteLine("Elapsed Time: " + elapsedTime);
        }
        else
        {
            Console.WriteLine("Stopwatch is not running. Use 'start' command to start it.");
        }
    }
}
