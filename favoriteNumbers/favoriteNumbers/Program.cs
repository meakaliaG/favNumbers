namespace favoriteNumbers
    /* Authors: Noah Wexler and Meakalia Gilman
     * Class: IGM.201.01 Interac Des & Prob Sol III
     * Due: 10.13.24
     */
{
    internal class Program
    {
        //  - -  subtract function   - -  
        static int Subtract(int a, int b)
        {
            return a - b;
        }

        //  - -  Add function   - -  
        static int Add(int a, int b)
        {
            return a + b;
        }

        //  - - Main   - -  
        static void Main(string[] args)
        {

            //  - -  declare variables and assign values   - -  
            int noahFavoriteNumber;
            int meaFavoriteNumber;
            noahFavoriteNumber = 21;
            meaFavoriteNumber = 17;

         
            //  - -  Addition  and Subtraction Logic   - -  
            int diff = Subtract(noahFavoriteNumber, meaFavoriteNumber);
            int sum = Add(noahFavoriteNumber, meaFavoriteNumber);


            //  - -  Printing to Console   - -  
            Console.WriteLine("Noah's Favorite Number: " + noahFavoriteNumber);
            Console.WriteLine("Meakalia's Favorite Number: " + meaFavoriteNumber);
            Console.WriteLine("When we add our favorite numbers together we get: " + sum);
            Console.WriteLine("When we subtract our favorite numbers we get: " + diff);


        }
    }
}
