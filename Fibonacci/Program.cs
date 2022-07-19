namespace Fibonacci;

using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Fibonacci().Take(10).ToList().ForEach(s => Console.WriteLine(s)); ;
    }

    private static IEnumerable<double> Fibonacci()
    {
        var series = new List<double>() { 0, 1 };
        yield return series[0];
        yield return series[1];
        while (true)
        {
            var current = series[^2] + series[^1];
            series.Add(current);
            yield return current;
        }
    }
}