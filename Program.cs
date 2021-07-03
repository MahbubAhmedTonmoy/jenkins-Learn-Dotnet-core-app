
using System;
using System.Collections.Generic;
using System.Linq;

namespace jenkins_Learn_Dotnet_core_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IEnumerable<int> numbers = new List<int>(){ 1,2,3};
            Console.WriteLine(numbers.Max());
        }
    }
}
