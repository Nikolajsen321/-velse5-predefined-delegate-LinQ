using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse5._3
{
    public static class PersonExtension
    {
        public static void SetAccepted(this List<Person> list, Predicate<Person> pred)
        {
            List<Person> list2 = list.FindAll(pred);
            list2.ForEach(p => p.Accepted = true);

        }

        public static void Reset(this List<Person> people) {
            foreach (Person person in people)
            {
                person.Accepted = false;
            }

        }
        

    }
}
