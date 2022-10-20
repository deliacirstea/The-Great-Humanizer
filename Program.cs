using Humanizer;
using System;

namespace DateTimeFormatInCSharpSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get current DateTime. It can be any DateTime object in your code.  
            DateTime aDate = DateTime.Now;

            // Format Datetime in different formats and display them  
            Console.WriteLine("What is the time now?");
            Console.WriteLine(aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss\n"));

            Console.WriteLine("--------------------------");
            //Console.ReadKey();

            Console.WriteLine("When is the feast?");
            Console.WriteLine($"The feast is in {DateTime.UtcNow.AddHours(15).Humanize()} ");
            
        }
        
    }
}
