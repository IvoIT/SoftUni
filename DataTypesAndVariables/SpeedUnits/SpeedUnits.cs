using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedUnits
{
    class SpeedUnits
    {
        static void Main(string[] args)
        {
            float meters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float mile = meters / 1609.0f;
            float kilometer = meters / 1000.0f;

            float roadTimeSeconds = seconds + (minutes * 60.0f) + (hours * 3600.0f);

            float metersPerSecond = meters / roadTimeSeconds;
            float kilometersPerHour = (metersPerSecond * 3600.0f) / 1000.0f;
            float milesPerHour = (metersPerSecond * 3600.0f) / 1609.0f;

            Console.WriteLine("{0}", metersPerSecond);
            Console.WriteLine("{0}", kilometersPerHour);
            Console.WriteLine("{0}", milesPerHour);
        }
    }
}
