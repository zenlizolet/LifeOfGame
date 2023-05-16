using System;
class Program
{
    static void Main(string[] args)
    {
        //onderstaand stuk code is nog van BEstelbus.
        //lees wat de user heeft ingevoerd
        //n = aantal pakjes 
        // r = aantal ritten

        // Lees de eerste regel in
        string input = Console.ReadLine();

        // Split de input op spaties
        string[] inputArr = input.Split(' ');

        // Haal de waarden van n en r uit de input
        long n = long.Parse(inputArr[0]);
        long r = long.Parse(inputArr[1]);

        // Maak een nieuwe array voor de getallen
        long[] numbers = new long[n];

        // Loop over de rest van de input en voeg de getallen toe aan de numbers array
        long counter = 0;
        while (counter < n)
        {
            // Lees een nieuwe regel
            string line = Console.ReadLine();

            // Split de regel op spaties
            string[] lineArr = line.Split(' ');

            // Loop over de waarden in de regel en voeg ze toe aan de numbers array
            foreach (string s in lineArr)
            {
                numbers[counter] = long.Parse(s);
                counter++;

                // Als de counter gelijk is aan n, stop de loop
                if (counter == n)
                {
                    break;
                }
            }
        }



    }
}