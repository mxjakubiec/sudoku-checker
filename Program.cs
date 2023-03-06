using System;
namespace sudoku_checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WIERSZ 1
            string[] wiersz1 = Console.ReadLine().Split(' ');
            int a1 = int.Parse(wiersz1[0]);
            int a2 = int.Parse(wiersz1[1]);
            int a3 = int.Parse(wiersz1[2]);
            int a4 = int.Parse(wiersz1[3]);
            int a5 = int.Parse(wiersz1[4]);
            int a6 = int.Parse(wiersz1[5]);
            int a7 = int.Parse(wiersz1[6]);
            int a8 = int.Parse(wiersz1[7]);
            int a9 = int.Parse(wiersz1[8]);
            
            //WIERSZ 2
            string[] wiersz2 = Console.ReadLine().Split(' ');
            int b1 = int.Parse(wiersz2[0]);
            int b2 = int.Parse(wiersz2[1]);
            int b3 = int.Parse(wiersz2[2]);
            int b4 = int.Parse(wiersz2[3]);
            int b5 = int.Parse(wiersz2[4]);
            int b6 = int.Parse(wiersz2[5]);
            int b7 = int.Parse(wiersz2[6]);
            int b8 = int.Parse(wiersz2[7]);
            int b9 = int.Parse(wiersz2[8]);

            //WIERSZ 3
            string[] wiersz3 = Console.ReadLine().Split(' ');
            int c1 = int.Parse(wiersz3[0]);
            int c2 = int.Parse(wiersz3[1]);
            int c3 = int.Parse(wiersz3[2]);
            int c4 = int.Parse(wiersz3[3]);
            int c5 = int.Parse(wiersz3[4]);
            int c6 = int.Parse(wiersz3[5]);
            int c7 = int.Parse(wiersz3[6]);
            int c8 = int.Parse(wiersz3[7]);
            int c9 = int.Parse(wiersz3[8]);

            //WIERSZ 4
            string[] wiersz4 = Console.ReadLine().Split(' ');
            int d1 = int.Parse(wiersz4[0]);
            int d2 = int.Parse(wiersz4[1]);
            int d3 = int.Parse(wiersz4[2]);
            int d4 = int.Parse(wiersz4[3]);
            int d5 = int.Parse(wiersz4[4]);
            int d6 = int.Parse(wiersz4[5]);
            int d7 = int.Parse(wiersz4[6]);
            int d8 = int.Parse(wiersz4[7]);
            int d9 = int.Parse(wiersz4[8]);

            //WIERSZ 5
            string[] wiersz5 = Console.ReadLine().Split(' ');
            int e1 = int.Parse(wiersz5[0]);
            int e2 = int.Parse(wiersz5[1]);
            int e3 = int.Parse(wiersz5[2]);
            int e4 = int.Parse(wiersz5[3]);
            int e5 = int.Parse(wiersz5[4]);
            int e6 = int.Parse(wiersz5[5]);
            int e7 = int.Parse(wiersz5[6]);
            int e8 = int.Parse(wiersz5[7]);
            int e9 = int.Parse(wiersz5[8]);

            //WIERSZ 6
            string[] wiersz6 = Console.ReadLine().Split(' ');
            int f1 = int.Parse(wiersz6[0]);
            int f2 = int.Parse(wiersz6[1]);
            int f3 = int.Parse(wiersz6[2]);
            int f4 = int.Parse(wiersz6[3]);
            int f5 = int.Parse(wiersz6[4]);
            int f6 = int.Parse(wiersz6[5]);
            int f7 = int.Parse(wiersz6[6]);
            int f8 = int.Parse(wiersz6[7]);
            int f9 = int.Parse(wiersz6[8]);

            //WIERSZ 7
            string[] wiersz7 = Console.ReadLine().Split(' ');
            int g1 = int.Parse(wiersz7[0]);
            int g2 = int.Parse(wiersz7[1]);
            int g3 = int.Parse(wiersz7[2]);
            int g4 = int.Parse(wiersz7[3]);
            int g5 = int.Parse(wiersz7[4]);
            int g6 = int.Parse(wiersz7[5]);
            int g7 = int.Parse(wiersz7[6]);
            int g8 = int.Parse(wiersz7[7]);
            int g9 = int.Parse(wiersz7[8]);

            //WIERSZ 8
            string[] wiersz8 = Console.ReadLine().Split(' ');
            int h1 = int.Parse(wiersz8[0]);
            int h2 = int.Parse(wiersz8[1]);
            int h3 = int.Parse(wiersz8[2]);
            int h4 = int.Parse(wiersz8[3]);
            int h5 = int.Parse(wiersz8[4]);
            int h6 = int.Parse(wiersz8[5]);
            int h7 = int.Parse(wiersz8[6]);
            int h8 = int.Parse(wiersz8[7]);
            int h9 = int.Parse(wiersz8[8]);

            //WIERSZ 9
            string[] wiersz9 = Console.ReadLine().Split(' ');
            int i1 = int.Parse(wiersz9[0]);
            int i2 = int.Parse(wiersz9[1]);
            int i3 = int.Parse(wiersz9[2]);
            int i4 = int.Parse(wiersz9[3]);
            int i5 = int.Parse(wiersz9[4]);
            int i6 = int.Parse(wiersz9[5]);
            int i7 = int.Parse(wiersz9[6]);
            int i8 = int.Parse(wiersz9[7]);
            int i9 = int.Parse(wiersz9[8]);


            if (a1+a2+a3+a4+a5+a6+a7+a8+a9 == 45 && b1 + b2 + b3 + b4 + b5 + b6 + b7 + b8 + b9 == 45 && c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 == 45 && d1 + d2 + d3 + d4 + d5 + d6 + d7 + d8 + d9 == 45 && e1 + e2 + e3 + e4 + e5 + e6 + e7 + e8 + e9 == 45 && f1 + f2 + f3 + f4 + f5 + f6 + f7 + f8 + f9 == 45 && g1 + g2 + g3 + g4 + g5 + g6 + g7 + g8 + g9 == 45 && h1 + h2 + h3 + h4 + h5 + h6 + h7 + h8 + h9 == 45 && i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 == 45)
            {
                if (a1 + b1 + c1 + d1 + e1 + f1 + g1 + h1 + i1 == 45 && a2 + b2 + c2 + d2 + e2 + f2 + g2 + h2 + i2 == 45 && a3 + b3 + c3 + d3 + e3 + f3 + g3 + h3 + i3 == 45 && a4 + b4 + c4 + d4 + e4 + f4 + g4 + h4 + i4 == 45 && a5 + b5 + c5 + d5 + e5 + f5 + g5 + h5 + i5 == 45 && a6 + b6 + c6 + d6 + e6 + f6 + g6 + h6 + i6 == 45 && a7 + b7 + c7 + d7 + e7 + f7 + g7 + h7 + i7 == 45 && a8 + b8 + c8 + d8 + e8 + f8 + g8 + h8 + i8 == 45 && a9 + b9 + c9 + d9 + e9 + f9 + g9 + h9 + i9 == 45)
                {
                    if(a1 + a2 + a3 + b1 + b2 + b3 + c1 + c2  + c3 == 45 && a4 + a5 + a6 + b4 + b5 + b6 + c4 + c5 + c6  == 45 && a7 + a8 + a9 + b7 + b8 + b9 + c7 + c8 + c9 == 45 && d1 + d2 + d3 + e1 + e2 + e3 + f1 + f2 + f3 == 45 && d4 + d5 + d6 + e4 + e5 + e6 + f4 + f5 + f6 == 45 && d7 + d8 + d9 + e7 + e8 + e9 + f7 + f8 + f9 == 45 && g1 + g2 + g3 + h1 + h2 + h3 + i1 + i2 + i3 == 45 && g4 + g5 + g6 + h4 + h5 + h6 + i4 + i5 + i6 == 45 && g7 + g8 + g9 + h7 + h8 + h9 + i7 + i8 + i9 == 45)
                    {
                        Console.WriteLine("yes");
                        return;
                    }
                    
             
                }
                
            }
            Console.WriteLine("no");

        }
    }
}