using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static Dictionary<int, long> memo = new Dictionary<int, long>();

    static void Main()
    {
        // Measure with memoization
        MeasureFibonacci(5);
        MeasureFibonacci(10);
        MeasureFibonacci(20);
        MeasureFibonacci(50);
        MeasureFibonacci(100);
    }

    static long Fibonacci(int n)
    {
        if (n <= 1) return n;

        if (memo.ContainsKey(n)) return memo[n];

        long result = Fibonacci(n - 1) + Fibonacci(n - 2);
        memo[n] = result;
        return result;
    }

    static void MeasureFibonacci(int n)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        long result = Fibonacci(n);

        stopwatch.Stop();
        Console.WriteLine($"Fibonacci({n}) = {result}");
        Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds} ms");
        Console.WriteLine();
    }
}
