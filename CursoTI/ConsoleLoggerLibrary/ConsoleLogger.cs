using DIPAbstractions;
using System;

namespace ConsoleLoggerLibrary
{
    public class ConsoleLogger : ILogger
    {
        public void Write(Activity activity)
        {
            // ...
            Console.WriteLine($"ConsoleLog: {activity.Message}");
        }
    }
}
