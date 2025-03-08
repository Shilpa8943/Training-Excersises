using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Start");

        // Calling an asynchronous method
        await PerformTaskAsync();

        Console.WriteLine("End");
    }

    static async Task PerformTaskAsync()
    {
        Console.WriteLine("Task started...");
        await Task.Delay(3000); // Simulates a 3-second delay (non-blocking)
        Console.WriteLine("Task completed!");
    }
}
