using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse5._3
{
    public class Person
    {
        private string _name;
        private int _age;
        private int _weight;
        private int _score;
        private bool _accepted;

        public Person(string data)
        {
            var values = data.Split(';');
            _name = values[0];
            _age = int.Parse(values[1]);
            _weight = int.Parse(values[2]);
            _score = int.Parse(values[3]);
            _accepted = false;
        }

        public string Name {  get { return _name; } set { _name = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public int Weight { get { return _weight; } set { _weight = value; } }
        public int Score { get { return _score; } set { _score = value; } }
        public bool Accepted { get { return _accepted;  } set { _accepted = value; } }


       
        public static List<Person> ReadCSVFile(string filename)
        {
            List<Person> list = new List<Person>();
            using (var file = new StreamReader(filename))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    var p = new Person(line);
                    list.Add(p);
                    //Console.WriteLine(p);
                }
            }
            return list;
        }


        


        public override string ToString()
        {
            return $" Navn: {_name}\n Age: {_age}\n Weight: {_weight}\n Score: {_score}\n Accepted {_accepted}" ;
        }

        public class SortByAgeAscending : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                
                return x.Age.CompareTo(y.Age);  
                
            }
        }



        public class SortByAgeDescending : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {

                return y.Age.CompareTo(x.Age);

            }
        }

    }
}
