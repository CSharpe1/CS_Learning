using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Scotts Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);



            List<double> grades = new List<double>() {12.7, 10.3, 6.11, 4.1};
            grades.Add(56.1);
            
            var result_average  = 0.0;
            var result_high     = 0.0;
            var result_low      = 100.0;
            var highGrade       = double.MaxValue;
            var lowgrade        = double.MinValue;
            foreach(double number in grades)
            {
                if(number   >   result_high) {
                    result_high =   number;
                }
                if(number   <   result_low) {
                    result_low = number;
                }

                result_average += number;                   
            }
            result_average /= grades.Count;
            System.Console.WriteLine($"The average grade is {result_average:N1}");   // N1 = formate as number with 1 decimal point.
            System.Console.WriteLine($"The lowest grade is {result_low:N1}");   // N1 = formate as number with 1 decimal point.
            System.Console.WriteLine($"The Highest grade is {result_high:N1}");   // N1 = formate as number with 1 decimal point.


        }
    }
}
