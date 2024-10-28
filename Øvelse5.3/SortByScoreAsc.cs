using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse5._3
{
    internal class SortByScoreAsc : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Score.CompareTo(y.Score);
        }
    }
}
