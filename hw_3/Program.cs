// See https://aka.ms/new-console-template for more information

using System.Collections;
using hw_second;

namespace hw_second
{
    class Program
    {
        static void Main()
        {
            var arr = new[] { new CombinedType(45, "hu"), new CombinedType(32, "ajack"), new CombinedType(322, "pum") };

            try
            {
                arr.Sort(LetsSort.Mode.Ascending, LetsSort.SortType.Insertion);
                foreach (var VARIABLE in arr)
                {   
                    Console.WriteLine($"{VARIABLE.Myint} - {VARIABLE.Mystr} ");
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Подайте заполненный массив данных");
            }
            
            Console.WriteLine("------------");
            try
            {
                arr.Sort(LetsSort.Mode.Descending, LetsSort.SortType.Merge, CombinationCompare.Instance);
                foreach (var VARIABLE in arr)
                {   
                    Console.WriteLine($"{VARIABLE.Myint} - {VARIABLE.Mystr} ");
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Подайте заполненный массив данных");
            }
            
            Console.WriteLine("------------");
            try
            {
                arr.Sort(LetsSort.Mode.Ascending, LetsSort.SortType.Quick, (IComparer<CombinedType>)CombinationCompare.Instance);
                foreach (var VARIABLE in arr)
                {   
                    Console.WriteLine($"{VARIABLE.Myint} - {VARIABLE.Mystr} ");
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Подайте заполненный массив данных");
            }
            
            
            Console.WriteLine("------------");

            try
            {
                Comparison<CombinedType> cmp = CombinationCompare.Compare;
            
                arr.Sort(LetsSort.Mode.Descending, LetsSort.SortType.Selection, cmp);
                foreach (var VARIABLE in arr)
                {   
                    Console.WriteLine($"{VARIABLE.Myint} - {VARIABLE.Mystr} ");
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Подайте заполненный массив данных");
            }
            
        }
    }
}
