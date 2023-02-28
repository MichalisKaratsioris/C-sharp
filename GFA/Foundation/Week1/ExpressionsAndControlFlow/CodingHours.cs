/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1
{
    internal class CodingHours
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            //
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52

            int hoursPerDay = 6;
            int weeksPerSemester = 17;
            int daysPerWeek = 5;
            int averageWorkWeeklyHours = 52;
            int totalWorkHoursPerSemester = averageWorkWeeklyHours * weeksPerSemester;
            int totalCodingHoursPerAttendee = hoursPerDay * weeksPerSemester * daysPerWeek;

            Console.WriteLine($"A GFA attendee, is coding {totalCodingHoursPerAttendee} hours in a semester.");
            Console.WriteLine($"Percentage of coding hours per semester is {((double)totalCodingHoursPerAttendee / totalWorkHoursPerSemester ) * 100}%.");

        }
    }
}
*/
