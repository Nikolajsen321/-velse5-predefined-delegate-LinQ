// See https://aka.ms/new-console-template for more information
using Øvelse5._3;

public class Start
{
    public static void Main(string[] args)
    {

        string filePath = @"C:\Users\nikol\OneDrive\Skrivebord\Opgave5.3.txt";
        List<Person> people = Person.ReadCSVFile(filePath);


        // Udskriv listen af personer
        foreach (var person in people)
        {
            Console.WriteLine(person + " HEJ");
        }

        List<Person> peopleUnder2 = people.FindAll(p => p.Age < 2);
        
        peopleUnder2.ForEach(p => Console.WriteLine(p));
        List<Person> peopleWithEqualNumSocre = people.FindAll(p => p.Age % 2 == 0);
        List<Person> peopleEqualWeighover60 = people.FindAll(p => p.Score % 2 == 0 && p.Weight > 60);
        List<Person> peopleDelig3 = people.FindAll(p => p.Weight % 3==0);

        //Husk FindAll() tager en predicate kaldet  Predicate match 

        //Opgave 5.4 
        int findIndexScore3 = people.FindIndex(p => p.Score == 3);
        int findIndexScore3AndAgeless10 = people.FindIndex(p => p.Score == 3 && p.Age < 10);
        int AlleUdnder10 = people.FindAll(p=> p.Age < 10 && p.Score== 3).Count;
        int AlleUdnder8 = people.FindIndex(p => p.Age < 8 && p.Score == 3);


        Console.WriteLine("Hvad sker med FindIndex() hvis der er ingen ");
        Console.WriteLine(AlleUdnder8);



        //OPgave 5.5  husk at sort by age er en indre klasse i person men gør samme som SortByScoreAsc klassen
        people.Sort(new Person.SortByAgeAscending());
        Console.WriteLine("---- stigende order ----");
        foreach(Person person in people)
        {
            Console.WriteLine(person.Name + " " + person.Age);
        }

        people.Sort(new Person.SortByAgeDescending());
        Console.WriteLine("---- faldene order ----");
        foreach (Person person in people)
        {
            Console.WriteLine(person.Name + " " + person.Age);
        }
        //Opgave 5.6 extension i Person extension 
        Console.WriteLine("---Opgave 5.6  ---- all true");

        people.SetAccepted(p => p.Score >= 6 && p.Age <= 40);

        foreach (Person person in people)
        {
            Console.WriteLine(person.ToString());
        }


        //Opgave 5.7 LINQ opgave 
        IEnumerable<Person> sortAscending = people.OrderBy(p=> p.Score).ThenBy(p=>p.Age);

        Console.WriteLine("Sorteret i stigende orden efter Score og Age:");
        foreach (var person in sortAscending)
        {
            Console.WriteLine($"{person.Name} - Score: {person.Score}, Age: {person.Age}");
        }

        IEnumerable<Person> sortDscending = people.OrderByDescending(p => p.Score).ThenBy(p => p.Age);
        Console.WriteLine("Sorteret i faldene orden efter Score og Age:");

        foreach (var person in sortDscending)
        {
            Console.WriteLine($"{person.Name} - Score: {person.Score}, Age: {person.Age}");
        }


        //Opgave 5.9
        people.Reset();

        Console.WriteLine("--------Reset------");

        foreach (Person person in people)
        {
            Console.Write(person.ToString() + "\n");

        }

        

    }
}
