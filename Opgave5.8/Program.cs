using System.Collections.Generic;

public class Start
{
    public static void Main(string[] args)
    {
        int[] numbers = { 34, 8, 56, 31, 79, 150, 88, 7, 200, 47, 88, 20 };
        string[] sNumbers = { "34", "8", "56", "31", "79", "150", "88", "7", "200", "47", "88", "20" };

        IEnumerable<int> number2DigtitAsc = numbers.Where(p=> p > 9).OrderBy(p => p);
        foreach(int number in number2DigtitAsc) { 
        
        Console.WriteLine(number);
        }

        Console.WriteLine("------Dscening order-----");
        IEnumerable<int> number2DigtitDsc = numbers.Where(p => p > 9).OrderByDescending(p => p);
        foreach (int number in number2DigtitDsc)
        {

            Console.WriteLine(number);
        }

        IEnumerable<string> number2DigitgsAscString = numbers.
            Where(n => n >= 10 && n < 100).  //tó - cifrede tal
            OrderBy(n => n). //Sorter
            Select(n => n.ToString()); //Konverter til string


        IEnumerable<string> number2DigitsAscString2 = sNumbers
        .Where(p => p.Length == 2)
        .OrderBy(p => p);


        IEnumerable<string> numbersdigitEven = numbers.Where(p => p > 9).
            OrderByDescending(p => p).
            Select(p => { if (p % 2 == 0) return p.ToString() + "Even"; else return p.ToString() + "Uneven"; });


        IEnumerable<string> numbersdigitEven2 = numbers.Where(p => p > 9).
          OrderByDescending(p => p).
          Select(p => p.ToString() + (p % 2 == 0 ? " even" : " uneven"));



    }
}