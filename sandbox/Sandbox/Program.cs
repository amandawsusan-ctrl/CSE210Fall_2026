using System;
using System.IO.Compression;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        int x = 20;
        int y = 20;
        int z = 30;

        if (x==10 || y ==20 && z ==30 )
        {
            Console.WriteLine("X is 10");
            Console.WriteLine("Y is fun");
        }

        else if (x==20)
        {
            Console.Write("We are in the else if");
        }
        else
        {
            Console.Write("Z if not much fun");
        }

    }




    

}

