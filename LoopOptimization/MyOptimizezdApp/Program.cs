using System;
using System.Diagnostics;  // Import the Stopwatch class
using System.Text;         // Import the StringBuilder class

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

        // Optimize the loop by batching output
        const int batchSize = 10000;  // Adjust batch size as needed
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < times; i++)
        {
            sb.AppendLine("Hello, World!");  // Aggregate messages in StringBuilder

            // Print messages in batches
            if ((i + 1) % batchSize == 0)
            {
                Console.Write(sb.ToString());
                sb.Clear();  // Clear the StringBuilder for the next batch
            }
        }

        // Print any remaining messages
        if (sb.Length > 0)
        {
            Console.Write(sb.ToString());
        }

        // Stop the stopwatch
        stopwatch.Stop();

        // Get the elapsed time
        TimeSpan elapsed = stopwatch.Elapsed;

        // Output the total time taken
        Console.WriteLine($"Total time taken: {elapsed.TotalSeconds} seconds");
    }
}
