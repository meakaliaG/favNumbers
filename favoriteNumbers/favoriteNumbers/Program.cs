namespace favoriteNumbers
    /* Authors: Noah Wexler and Meakalia Gilman
     * Class: IGM.201.01 Interac Des & Prob Sol III
     * Due: 10.13.24
     */
{
    internal class Program
    {
        //static addition function here
        static void add(int a, int b) { }


        static void Main(string[] args)
        {
            //declare variables
            int noahFavoiteNumber;
            int meaFavoriteNumber;

            //initialize variables
            //REPLACE 0 WITH UR FAV NUM
            noahFavoiteNumber = 0;
            meaFavoriteNumber = 17;

            //subtract function
            static int subtract(int a, int b)
            {
                return a - b;
            }

            //finally, the program start!
            //DELETE FOLLOWING FORWARD SLASHES
            //Console.WriteLine("Noah's Favorite Number: " + noahFavoriteNumber);
            Console.WriteLine("Meakalia's Favorite Number: " + meaFavoriteNumber);

            //DELETE FOLLOWING FORWARD SLASHES
            //int sum = add(noahFavoiteNumber, meaFavoriteNumber);
            int diff = 0;
            if (noahFavoiteNumber > meaFavoriteNumber)
            {
                diff = subtract(noahFavoiteNumber, meaFavoriteNumber);
            }
            else
            {
                diff = subtract(meaFavoriteNumber, noahFavoiteNumber);
            }

            //print results
            //DELETE FOLLOWING FORWARD SLASHES
            //Console.WriteLine("Favorite numbers sum: " + sum);
            Console.WriteLine("Favorite numbers difference: " + diff);


        }
    }
}
