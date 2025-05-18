// 1. Select all elements from an integer array.

using System;
using System.Linq;
using System.Collections.Generic;

//public class Program
//{
//    private static void Main(string[] args)
//    {
//        int[] numbers = { 10, 20, 30, 40, 50 };

//        var allNumbers = numbers.Select(n => n * 2);

//        Console.WriteLine(allNumbers);

//        foreach (var number in allNumbers)
//        {
//            Console.WriteLine(number);
//        }
//        Console.ReadLine();
//    }
//}

// 2. Select only even numbers from a list

//public class Program
//{
//    private static void Main(string[] args)
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

//        var evenNumbers = numbers.Where(x => x % 2 == 0);

//        Console.WriteLine("Even Numbers: ");

//        foreach (var num in evenNumbers)
//        {
//            Console.WriteLine(num);
//        }

//        Console.ReadLine();
//    }
//}

// 3. Count how many numbers are greater than 50 

//public class Program
//{
//    private static void Main(string[] args)
//    {
//        List<int> numbers = new List<int> { 10, 20, 30, 50, 60, 70, 100 };

//        int count = numbers.Count(x => x > 50);

//        Console.WriteLine("Count of numbers greater than 50: " + count);

//        Console.ReadLine();
//    }
//}

// 4. Sort a list of strings alphabetically

//public class Program
//{
//    private static void Main(string[] args)
//    {
//        List<string> name = new List<string> { "Jaydeep", "Om", "Rutwik", "Shubham", "Pranav", "Akshay", "Prathamesh", "Suraj" };

//        var alphabeticalName = name.OrderBy(x => x).ToList();

//        Console.WriteLine(alphabeticalName);

//        foreach (var nameItem in alphabeticalName)
//        {
//            Console.WriteLine(nameItem);
//        }

//        Console.ReadLine();
//    }
//}

// 5. Find the maximum value in a list

//public class Program
//{
//    private static void Main(string[] args)
//    {
//        List<int> list = new List<int> { 10, 20, 30, 40, 100 };

//        var maxNumber = list.Max(x => x);

//        Console.WriteLine($"Maximum Value :{maxNumber}");

//        Console.ReadLine();
//    }
//}

// 6. Find the minimum value in a list

//public class Program
//{
//    private static void Main(string[] args)
//    {
//        List<int> list = new List<int> { 10, 20, 30, 40, 100 };

//        var minNumber = list.Min(x => x);

//        Console.WriteLine($"Minimum Value :{minNumber}");

//        Console.ReadLine();
//    }
//}

// 7. Get the sum of all elements in a list

//public class Program
//{
//    private static void Main(string[] args)
//    {
//        List<int> list = new List<int> { 10, 20, 30, 40, 50, 60 };
//        var sumAll = list.Sum(x => x);

//        Console.WriteLine($"Sum All: {sumAll}");
//        Console.ReadLine();
//    }
//}

// 8. Check if all elements are positive

//public class Program
//{
//    private static void Main(string[] args)
//    {
//        List<int> list = new List<int> { 10, 20, 50, 70, 90, 100 };

//        var positive = list.All(x => x > 0);

//        Console.WriteLine("Positive Number: ");

//        Console.WriteLine("Are all numbers positive? " + positive);

//        Console.ReadLine();
//    }
//}

// 9. Check if any number is divisible by 5

//public class Program
//{
//    private static void Main(string[] args)
//    {
//        List<int> list = new List<int> { 1, 2, 10, 50, 75, 12 };

//        var check = list.Any(x => x % 5 == 0);

//        Console.WriteLine("Divsible or Not");

//        Console.WriteLine("Are all numbers positive? " + check);

//        Console.ReadLine();
//    }
//}

// 10. Skip the first 5 elements and take the next 3

//public class Program
//{
//    private static void Main(string[] args)
//    {
//        List<int> element = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

//        var skip = element.Skip(5).Take(3);

//        Console.WriteLine("Result after Skip and Take:");

//        foreach (var item in skip)
//        {
//            Console.WriteLine(item);
//        }

//        Console.ReadLine();
//    }
//}