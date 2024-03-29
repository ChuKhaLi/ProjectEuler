﻿using System;

namespace CountingSundays
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=19
         * You are given the following information, but you may prefer to do 
         * some research for yourself.
         * 1 Jan 1900 was a Monday.
         * Thirty days has September,
         * April, June and November.
         * All the rest have thirty-one,
         * Saving February alone,
         * Which has twenty-eight, rain or shine.
         * And on leap years, twenty-nine.
         * A leap year occurs on any year evenly divisible by 4, but not on 
         * a century unless it is divisible by 400.
         * How many Sundays fell on the first of the month during 
         * the twentieth century (1 Jan 1901 to 31 Dec 2000)?
         */
        static void Main(string[] args)
        {
            int sundays = 0;
            for (int y = 1901; y <= 2000; y++)
                sundays += CountSundays(y);
            Console.WriteLine("Sundays fell on the first of the month during " +
                "the twentieth century is: " + sundays);
            Console.ReadKey();
        }

        static int CountSundays(int year)
        {
            int count = 0;
            for (int i = 1; i <= 12; i++)
            {
                var date = new DateTime(year, i, 1);
                if (date.DayOfWeek == DayOfWeek.Sunday) count++;
            }
            return count;
        }
    }
}
