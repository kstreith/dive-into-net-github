using System;
using System.Collections.Generic;
using System.Linq;

namespace DiveIntoNetCoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var val = r.Next(100);
            var list = new List<int> { 5, 10, 22 };
            string.Join(", ", list);
            var mappedValues = list.Select(x => x * x);
            var mappedResult = mappedValues.ToList();
        }
    }
}
