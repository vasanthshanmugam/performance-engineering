using System;
using System.Diagnostics;  // Import the Stopwatch class

class Program
{
    static void Main()
    {
        // Number of times to print the message
        int times = 1000000;  // A large number to illustrate the inefficiency

        // Create a Stopwatch instance
        Stopwatch stopwatch = new Stopwatch();
        
        // Start the stopwatch
        stopwatch.Start();

        // Unoptimized loop
        for (int i = 0; i < times; i++)
        {
            Console.WriteLine("Hello, World!");  // Unoptimized: printing to the console is expensive
        }

        // Stop the stopwatch
        stopwatch.Stop();

        // Get the elapsed time
        TimeSpan elapsed = stopwatch.Elapsed;

        // Output the total time taken
        Console.WriteLine($"Total time taken: {elapsed.TotalSeconds} seconds");
    }
}
