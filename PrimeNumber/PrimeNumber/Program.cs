using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("開始"); Console.WriteLine();
        Console.WriteLine();
        int x;
        int y;
        bool ItsPrimeNumber;
        int PrimeNumber;
        x = 6;
        while( x <= 15)
        {
            ItsPrimeNumber = true;
            PrimeNumber = 2; 
            while ((PrimeNumber <= (x - 1)))/*) && ItsPrimeNumber)*/
               // First , 2<=5 so keep while
            {
                if (x % PrimeNumber == 0) //First , 6/2=0
                {
                     ItsPrimeNumber= false; //可整除時，不是質數
                }
                PrimeNumber = PrimeNumber + 1; //First, PN=3
            }
            if (ItsPrimeNumber)
            {
                Console.Write(x + " ");
            }
            x = x+1; //First , 7繼續累加直到16
        }
        Console.WriteLine();
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        y = 7;
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine("結束");
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine();
    }
}

