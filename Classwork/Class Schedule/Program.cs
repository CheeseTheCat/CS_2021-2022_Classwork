// James Hooper
// 9/21
// Class Schedule

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Schedule
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a string holding the contents and the table
            String schedule = @"-----------------------------------------
|    Class name                Time     |
-----------------------------------------
|    Us History      |         08:00    |
|    Astronomy Uni   |         09:15    |
|    Seminary        |         10:30    |
|    Lunch           |         11:40    |
|    ELA             |         12:15    |
|    ACT Prep        |         01:30    |
|    C# Gaming       |         08:00    |
|    C# Gaming       |         09:15    |
|    Study Hall      |         10:30    |
|    Lunch           |         11:40    |
|    Art Foundations |         12:15    |
|    Math 3          |         01:30    |
-----------------------------------------";

            // Prints the table to the console
            Console.WriteLine(schedule);

            // Prevents the windo from closing instantly
            Console.ReadLine();
        }
    }
}
