// See https://aka.ms/new-console-template for more information

public class Start
{
    public static void Main(string[] args)
    {
        List<int> list = new List<int>()
        {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            20,
            30
        };

        //Query Method Where(), select(), OrderBy()  er metoder som bruges direkte på samling

        IEnumerable<int> result = list.Where(i=> i % 2 == 0);
        foreach(int i in result)
        {
            Console.WriteLine(i);
        }

        IEnumerable<int> result2 = list.Where(i => i.ToString().Length == 2);
        Console.WriteLine("Her er det for dem med to cifre ");
        foreach(int i in result2)
        {
            Console.WriteLine(i);
        }


      
        IEnumerable<int> result3 = list.Where(i => i % 2 == 0).OrderBy(i => -i);

        Console.WriteLine("Sortering");

        foreach (int i in result3)
        {
            Console.WriteLine(i);
        }


        // En anden måde er at bruge query expression hvor syntaks ligner SQL, from, where, select

        /*
         * vars = from p in persons
           where p.Approved
           orderby p.Rating
           select p.Name;
         */
    }
}
