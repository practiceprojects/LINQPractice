using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    class Foo
    {
        public int Number { get; set; }
        public bool IsFizz { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //FIZZBUZZ
            var numbers = Enumerable.Range(1, 100);

            var results = from n in numbers
                          select new
                          {
                              Number = n,
                              IsFizzBuzz = n % 15 == 0,
                              IsFizz = n % 3 == 0,
                              IsBuzz = n % 5 == 0
                          };

            foreach (var item in results)
            {
                if (item.IsFizzBuzz)
                    Console.WriteLine("FizzBuzz");
                if (item.IsFizz)
                    Console.WriteLine("Fizz");
                if (item.IsBuzz)
                    Console.WriteLine("Buzz");
                else Console.WriteLine(numbers.ToString());
            }
            Console.ReadLine();
        }
    }
}




//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 12 };

//var numbersList = from number in numbers
//                  where number < 6
//                  select number;

//foreach (var number in numbersList)
//{
//    Console.WriteLine(number);
//}

//numbersList = from number in numbers
//              where number.ToString().StartsWith("1")
//              select number;

//foreach (var number in numbersList)
//{
//    Console.WriteLine(number * 2);
//}
//Console.ReadLine();