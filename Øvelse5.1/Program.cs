public class Start()
{
    public static void Main(string[] args)
    {


        //int[] intArray = new int[] { 2, 3, 4 };
        //// Action peger på ShowSquares-metoden
        //Action<int> action = ShowSquares;
        //// Anvender Array.ForEach til at anvende Action på hvert element i intArray
        //Array.ForEach(intArray, action);

      
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

        int lastHighest = 0;

        list.ForEach(item =>
        {
            if (item % 2 == 0)
            {
                Console.WriteLine(item);
            }

            if (item > 15) // sidste større end 15?
            {
                lastHighest = item;
                

            }
        });
        Console.WriteLine($"sidste tal større end 15 er {lastHighest} og dens index er {list.IndexOf(lastHighest)}"  );
    }


  
}
