using System;

namespace DayOfWeek;

internal class Program
{
    static void Main(string[] args)
    {

        //PROBLEM STATMENT

        //To the Util Class add dayOfWeek static function that takes a date as input and
        //prints the day of the week that date falls on.Your program should take three
        //command­line arguments: m (month), d (day), and y (year). For m use 1 for January,
        //2 for February, and so forth.For output print 0 for Sunday, 1 for Monday, 2 for
        //Tuesday, and so forth.Use the following formulas, for the Gregorian calendar (where / denotes integer division):
        //y0 = y − (14 − m) / 12
        //x = y0 + y0/4 − y0/100 + y0/400
        //m0 = m + 12 × ((14 − m) / 12) − 2
        //d0 = (d + x + 31m0/ 12) mod 7

        //SOLUTION

        //Taking in the 3 inputs from the user
        Console.Write("Please Enter month : ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please Enter day : ");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please Enter year : ");
        int y = Convert.ToInt32(Console.ReadLine());

        //y0 = y − (14 − m) / 12
        int y0 = y - (14 - m) / 12;
        Console.WriteLine("y0 : "+y0);

        //x = y0 + y0/4 − y0/100 + y0/400
        int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
        Console.WriteLine("x : "+x);

        //m0 = m + 12 × ((14 − m) / 12) − 2
        int m0 = m + 12 * ((14-m) /12) -2;
        Console.WriteLine("m0 : "+m0);

        //d0 = (d + x + 31m0/ 12) mod 7
        int d0 = (d + x + 31 * m0 / 12) % 2;
        Console.WriteLine("d0 : "+d0);

        //creating an array of the days of week 
        string[] days = {"Sunday","Monday"," Tuesday","Wednesday", "Thursday", "Friday", "Saturday" };

        //For output we are taking the array and calling the value at index d0
        Console.WriteLine("Day of the Week : "+ days[d0]);

    }
}




