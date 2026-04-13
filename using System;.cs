using System;

class Program
{
    static void CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
    {
        int appleCount = 0;
        int orangeCount = 0;

        foreach (int d in apples)
        {
            int position = a + d;
            if (position >= s && position <= t)
            {
                appleCount++;
            }
        }

        foreach (int d in oranges)
        {
            int position = b + d;
            if (position >= s && position <= t)
            {
                orangeCount++;
            }
        }

        Console.WriteLine(appleCount);
        Console.WriteLine(orangeCount);
    }

    static void Main()
    {
        // Ввід
        string[] st = Console.ReadLine().Split();
        int s = int.Parse(st[0]);
        int t = int.Parse(st[1]);

        string[] ab = Console.ReadLine().Split();
        int a = int.Parse(ab[0]);
        int b = int.Parse(ab[1]);

        string[] mn = Console.ReadLine().Split();
        int m = int.Parse(mn[0]);
        int n = int.Parse(mn[1]);

        int[] apples = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] oranges = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        // Виклик функції
        CountApplesAndOranges(s, t, a, b, apples, oranges);
    }
}