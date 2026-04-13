using System;
using System.Collections.Generic;

class Program
{
    static List<int> GradingStudents(List<int> grades)
    {
        List<int> result = new List<int>();

        foreach (int grade in grades)
        {
            if (grade < 38)
            {
                result.Add(grade);
            }
            else
            {
                int nextMultiple = ((grade / 5) + 1) * 5;

                if (nextMultiple - grade < 3)
                {
                    result.Add(nextMultiple);
                }
                else
                {
                    result.Add(grade);
                }
            }
        }

        return result;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> grades = new List<int>();

        for (int i = 0; i < n; i++)
        {
            grades.Add(int.Parse(Console.ReadLine()));
        }

        List<int> rounded = GradingStudents(grades);

        foreach (int g in rounded)
        {
            Console.WriteLine(g);
        }
    }
}