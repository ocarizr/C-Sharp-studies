using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace teste_ex2
{
    class Result
    {

        /*
         * Complete the 'findSchedules' function below.
         *
         * The function is expected to return a STRING_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER workHours
         *  2. INTEGER dayHours
         *  3. STRING pattern
         */

        public static List<string> findSchedules(int workHours, int dayHours, string pattern)
        {
            List<string> _findSchedules = new List<string>();   // A temp variable to be returned
            int openDays = 0;                                   // The ammount of days to be filled
            StringBuilder schedule = new StringBuilder();       // The stringBuilder to create the filled result string

            int pos;                                 // store the ammount of positions to be filled
            int openCount = 0;

            foreach (char c in pattern)
            {
                if (c != '?')
                {
                    workHours = workHours - int.Parse(c.ToString());
                }
                else
                {
                    openDays++;
                }
            }

            pos = openDays;

            if ((workHours / openDays) == dayHours)
            {
                foreach (char c in pattern)
                {
                    if (c == '?')
                    {
                        schedule.Append(dayHours);
                    }
                    else
                    {
                        schedule.Append(c);
                    }
                }
                _findSchedules.Add(schedule.ToString());
                return _findSchedules;
            }
            else
            {
                if (dayHours > workHours)
                {
                    for (int i = 0; i < openDays; i++)
                    {
                        foreach (char c in pattern)
                        {
                            if (c == '?')
                            {
                                if ((pos - 1) == openCount)
                                {
                                    schedule.Append(workHours);
                                }
                                else
                                {
                                    schedule.Append('0');
                                }
                                openCount++;
                            }
                            else
                            {
                                schedule.Append(c);
                            }
                        }
                        _findSchedules.Add(schedule.ToString());
                        schedule.Clear();
                        openCount = 0;
                        pos--;
                    }
                    return _findSchedules;
                }
                else
                {
                    if ((workHours % dayHours) == 0)
                    {
                        int daysToWork = workHours / dayHours;

                        schedule = new StringBuilder("0000000");

                        for (int i = openDays - daysToWork; i >= 0; i--)
                        {
                            schedule = new StringBuilder("0000000");
                            schedule[i] = char.Parse(dayHours.ToString());
                            if (daysToWork > 1)
                            {
                                for (int j = (openDays - daysToWork) + 1; j > i; j--)
                                {
                                    schedule = new StringBuilder("0000000");
                                    schedule[i] = char.Parse(dayHours.ToString());
                                    schedule[j] = char.Parse(dayHours.ToString());
                                    if (daysToWork > 2)
                                    {
                                        for (int k = (openDays - daysToWork) + 2; k > j; k--)
                                        {
                                            schedule = new StringBuilder("0000000");
                                            schedule[i] = char.Parse(dayHours.ToString());
                                            schedule[j] = char.Parse(dayHours.ToString());
                                            schedule[k] = char.Parse(dayHours.ToString());
                                            if (daysToWork > 3)
                                            {
                                                for (int x = (openDays - daysToWork) + 3; x > k; x--)
                                                {
                                                    schedule = new StringBuilder("0000000");
                                                    schedule[i] = char.Parse(dayHours.ToString());
                                                    schedule[j] = char.Parse(dayHours.ToString());
                                                    schedule[k] = char.Parse(dayHours.ToString());
                                                    schedule[x] = char.Parse(dayHours.ToString());
                                                    if (daysToWork > 4)
                                                    {
                                                        for (int y = (openDays - daysToWork) + 4; y > x; y--)
                                                        {
                                                            schedule = new StringBuilder("0000000");
                                                            schedule[i] = char.Parse(dayHours.ToString());
                                                            schedule[j] = char.Parse(dayHours.ToString());
                                                            schedule[k] = char.Parse(dayHours.ToString());
                                                            schedule[x] = char.Parse(dayHours.ToString());
                                                            schedule[y] = char.Parse(dayHours.ToString());
                                                            if (daysToWork > 5)
                                                            {
                                                                for (int z = (openDays - daysToWork) + 5; z > y; z--)
                                                                {
                                                                    schedule = new StringBuilder("0000000");
                                                                    schedule[i] = char.Parse(dayHours.ToString());
                                                                    schedule[j] = char.Parse(dayHours.ToString());
                                                                    schedule[k] = char.Parse(dayHours.ToString());
                                                                    schedule[x] = char.Parse(dayHours.ToString());
                                                                    schedule[y] = char.Parse(dayHours.ToString());
                                                                    schedule[z] = char.Parse(dayHours.ToString());
                                                                    _findSchedules.Add(schedule.ToString());
                                                                }
                                                            }
                                                            if (!_findSchedules.Contains(schedule.ToString()))
                                                            {
                                                                _findSchedules.Add(schedule.ToString());
                                                            }
                                                        }
                                                    }
                                                    if (!_findSchedules.Contains(schedule.ToString()))
                                                    {
                                                        _findSchedules.Add(schedule.ToString());
                                                    }
                                                }
                                            }
                                            if (!_findSchedules.Contains(schedule.ToString()))
                                            {
                                                _findSchedules.Add(schedule.ToString());
                                            }
                                        }
                                    }
                                    if (!_findSchedules.Contains(schedule.ToString()))
                                    {
                                        _findSchedules.Add(schedule.ToString());
                                    }
                                }
                            }
                            if (!_findSchedules.Contains(schedule.ToString()))
                            {
                                _findSchedules.Add(schedule.ToString());
                            }
                        }

                        return _findSchedules;
                    }
                    else
                    {
                        int lastDayWorkHour = workHours % dayHours;

                        if (workHours / dayHours == openDays - 1)
                        {
                            for (int i = 0; i < openDays; i++)
                            {
                                foreach (char c in pattern)
                                {
                                    if (c == '?')
                                    {
                                        if ((pos - 1) == openCount)
                                        {
                                            schedule.Append(lastDayWorkHour);
                                        }
                                        else
                                        {
                                            schedule.Append(dayHours);
                                        }
                                        openCount++;
                                    }
                                    else
                                    {
                                        schedule.Append(c);
                                    }
                                }
                                _findSchedules.Add(schedule.ToString());
                                schedule.Clear();
                                openCount = 0;
                                pos--;
                            }
                            return _findSchedules;
                        }
                        else
                        {
                            schedule.Clear();
                            for (int a = 0; a < 7; a++)
                            {
                                schedule.Append(char.Parse(dayHours.ToString()));
                            }

                            int daysToWork = workHours / dayHours + 1;

                            for (int i = openDays - daysToWork; i >= 0; i--)
                            {
                                schedule.Clear();
                                for (int a = 0; a < 7; a++)
                                {
                                    schedule.Append(char.Parse(dayHours.ToString()));
                                }
                                schedule[i] = char.Parse(lastDayWorkHour.ToString());
                                if (daysToWork > 1)
                                {
                                    for (int j = (openDays - daysToWork) + 1; j > i; j--)
                                    {
                                        schedule.Clear();
                                        for (int a = 0; a < 7; a++)
                                        {
                                            schedule.Append(char.Parse(dayHours.ToString()));
                                        }
                                        schedule[i] = char.Parse(lastDayWorkHour.ToString());
                                        schedule[j] = '0';
                                        if (daysToWork > 2)
                                        {
                                            for (int k = (openDays - daysToWork) + 2; k > j; k--)
                                            {
                                                schedule.Clear();
                                                for (int a = 0; a < 7; a++)
                                                {
                                                    schedule.Append(char.Parse(dayHours.ToString()));
                                                }
                                                schedule[i] = char.Parse(lastDayWorkHour.ToString());
                                                schedule[j] = '0';
                                                schedule[k] = '0';
                                                if (daysToWork > 3)
                                                {
                                                    for (int x = (openDays - daysToWork) + 3; x > k; x--)
                                                    {
                                                        schedule.Clear();
                                                        for (int a = 0; a < 7; a++)
                                                        {
                                                            schedule.Append(char.Parse(dayHours.ToString()));
                                                        }
                                                        schedule[i] = char.Parse(lastDayWorkHour.ToString());
                                                        schedule[j] = '0';
                                                        schedule[k] = '0';
                                                        schedule[x] = '0';
                                                        if (daysToWork > 4)
                                                        {
                                                            for (int y = (openDays - daysToWork) + 4; y > x; y--)
                                                            {
                                                                schedule.Clear();
                                                                for (int a = 0; a < 7; a++)
                                                                {
                                                                    schedule.Append(char.Parse(dayHours.ToString()));
                                                                }
                                                                schedule[i] = char.Parse(lastDayWorkHour.ToString());
                                                                schedule[j] = '0';
                                                                schedule[k] = '0';
                                                                schedule[x] = '0';
                                                                schedule[y] = '0';
                                                                if (daysToWork > 5)
                                                                {
                                                                    for (int z = (openDays - daysToWork) + 5; z > y; z--)
                                                                    {
                                                                        schedule.Clear();
                                                                        for (int a = 0; a < 7; a++)
                                                                        {
                                                                            schedule.Append(char.Parse(dayHours.ToString()));
                                                                        }
                                                                        schedule[i] = char.Parse(lastDayWorkHour.ToString());
                                                                        schedule[j] = '0';
                                                                        schedule[k] = '0';
                                                                        schedule[x] = '0';
                                                                        schedule[y] = '0';
                                                                        schedule[z] = '0';
                                                                        _findSchedules.Add(schedule.ToString());
                                                                    }
                                                                }
                                                                if (!_findSchedules.Contains(schedule.ToString()))
                                                                {
                                                                    _findSchedules.Add(schedule.ToString());
                                                                }
                                                            }
                                                        }
                                                        if (!_findSchedules.Contains(schedule.ToString()))
                                                        {
                                                            _findSchedules.Add(schedule.ToString());
                                                        }
                                                    }
                                                }
                                                if (!_findSchedules.Contains(schedule.ToString()))
                                                {
                                                    _findSchedules.Add(schedule.ToString());
                                                }
                                            }
                                        }
                                        if (!_findSchedules.Contains(schedule.ToString()))
                                        {
                                            _findSchedules.Add(schedule.ToString());
                                        }
                                    }
                                }
                                if (!_findSchedules.Contains(schedule.ToString()))
                                {
                                    _findSchedules.Add(schedule.ToString());
                                }
                            }

                            return _findSchedules;
                        }
                    }
                }
            }
        }
    }

    class WorkSchedule
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int workHours = Convert.ToInt32(Console.ReadLine().Trim());

            int dayHours = Convert.ToInt32(Console.ReadLine().Trim());

            string pattern = Console.ReadLine();

            List<string> result = Result.findSchedules(workHours, dayHours, pattern);

            Console.Write(String.Join("\n", result));

            Console.Read();

            //textWriter.WriteLine(String.Join("\n", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
