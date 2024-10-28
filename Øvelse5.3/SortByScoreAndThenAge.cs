using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse5._3
{
    internal class SortByScoreAndThenAge : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int scoreComparison = x.Score.CompareTo(y.Score);
            if (scoreComparison == 0)
            {
                return x.Age.CompareTo(y.Age);
            }
            return scoreComparison;

        }
    }

}
