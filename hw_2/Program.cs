// See https://aka.ms/new-console-template for more information

using System.Collections;
using hw_second;

namespace hw_second
{
    class Program
    {
        public static bool CheckDistinct<T>(T[] array, IEqualityComparer<T> comparer)
        {
            if (array.Distinct(comparer).Count() != array.Length)
            {
                throw new ArgumentException();
            }
            return true;
        }

        private static void TaskOne()   
        {
            Console.WriteLine("Первый метод:");
            var ls = new List<int>() { 1, 2, 3 };
            
            var isUnique = true;
            var comparerrrr = pupu<int>.Instance;

            try
            {
                var fl = CheckDistinct(ls.ToArray(), comparerrrr);
            }
            catch (ArgumentException)
            {
                isUnique = false;
            }
            
            
            if (!isUnique)
            {
                Console.WriteLine("Пожалуйста, введите массив из уникальных элементов");
            }
            else
            {
                var q = ls.FirstTask(2);

                Console.Write("[ ");
                foreach (var VARIABLE in q)
                {
                    Console.Write("[");
                    foreach (var item in VARIABLE)
                    {
                        Console.Write($" {item} ");
                    }
                    Console.Write("] ");
  
                }
                Console.WriteLine("]");

            }
            
        }
        
        private static void TaskTwo()
        {
            Console.WriteLine("Второй метод:");
            var ls = new List<int>() { 1, 2, 3 };
            
            var isUnique = true;
            var comparerrrr = pupu<int>.Instance;

            try
            {
                var fl = CheckDistinct(ls.ToArray(), comparerrrr);
            }
            catch (ArgumentException)
            {
                isUnique = false;
            }
            
            
            
            if (!isUnique)
            {
                Console.WriteLine("Пожалуйста, введите массив из уникальных элементов");
            }
            else
            {
                var q = ls.SecondTask();

                Console.Write("[ ");
                foreach (var VARIABLE in q)
                {
                    Console.Write("[");
                    foreach (var item in VARIABLE)
                    {
                        Console.Write($" {item} ");
                    }
                    Console.Write("] ");
  
                }
                Console.WriteLine("]");

            }
        }
        
        private static void TaskThree()
        {
            Console.WriteLine("Третий метод:");
            var ls = new List<int>() { 1, 2, 3 };
            
            var isUnique = true;
            var comparerrrr = pupu<int>.Instance;

            try
            {
                var fl = CheckDistinct(ls.ToArray(), comparerrrr);
            }
            catch (ArgumentException)
            {
                isUnique = false;
            }
            
            
            if (!isUnique)
            {
                Console.WriteLine("Пожалуйста, введите массив из уникальных элементов");
            }
            else
            {
                var q = ls.ThirdTask();

                Console.Write("[ ");
                foreach (var VARIABLE in q)
                {
                    Console.Write("[");
                    foreach (var item in VARIABLE)
                    {
                        Console.Write($" {item} ");
                    }
                    Console.Write("] ");
  
                }
                Console.WriteLine("]");

            }
        }
        
        static void Main()
        {
            TaskOne();
            TaskTwo();
            TaskThree();
        }
    }
}
