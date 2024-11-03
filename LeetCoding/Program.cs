using System;
using System.Linq.Expressions;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Leetcode
{
    static void swap(int[] arr, int a, int b)
    {
        int h = arr[a];
        arr[a] = arr[b];
        arr[b] = h;
    }

    static int Fibonacci(int n)
    {
        List<int> dp = new List<int>();
        dp.Add(0);
        dp.Add(1);
        if (n < 2)
        {
            return dp[n];
        }
        for (int i = 2; i <= n; i++)
        {
            dp.Add(dp[i - 1] + dp[i - 2]);
        }
        return dp[n];
    }

    static int MinMovesToSeat(int[] seats, int[] students)
    {
        Array.Sort(seats);
        Array.Sort(students);
        int movecount = 0;
        for (int i = 0; i < seats.Length; i++)
        {
            movecount = movecount + (Math.Abs(seats[i] - students[i]));
        }
        return movecount;
    }
    public static int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            int differenz = target - nums[i];
            if (map.ContainsKey(differenz))
            {
                return (new int[] { i, map[target - nums[i]] });
            }
            else map[nums[i]] = i;
        }
        return new int[] { };
    }
    public static bool IsPalindrome(int x)
    {
    
        if (x < 0 || (x % 10 == 0 && x != 0))
        {
            return false;
        }

        int reversed = 0;
        int original = x;

        while (x > 0)
        {
            int remainder = x % 10;
            x /= 10;
            reversed = reversed * 10 + remainder;
        }

        return reversed == original;
    }

    static void Main(string[] args)
    {
        int[] test = { 2, 7, 11, 15 };
        int[] sol = TwoSum(test, 9);
        foreach (int item in sol)
        {
            Console.WriteLine(item);
        }
    }
}
