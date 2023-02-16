using System.Net.Http.Headers;
using System.Text;

namespace szokereso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Szokereso> Szavak = new();

            using StreamReader sr = new(@"..\..\..\src\szavak.txt", Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                Szavak.Add(new Szokereso(sr.ReadLine()));
            }
            
            
            Console.WriteLine($"1. Feladat - Szavak száma: {Szavak.Count} db");

            int im = 0;
            int max = int.MinValue;
            while (im<Szavak.Count)
            {
                if (Szavak[im].Szo.Length>max)
                {
                    max = Szavak[im].Szo.Length;
                }
                im++;
            }
            
            Console.WriteLine($"2. Feladat - Leghosszabb szó hossza: {max} db karakter");

            Console.WriteLine("3. Feladat - Leghosszabb szó/szavak:");

            for (int i = 0; i < Szavak.Count; i++)
            {
                if (Szavak[i].Szo.Length==max)
                {
                    Console.Write($"\t{Szavak[i].Szo}\n");
                }
            }

            Console.Write("5. Feladat - Szavak kiírása\n\t");

            string betu = "#";
            for (int i = 0; i < 16; i++)
            {               
                for (int j = 0; j < 16; j++)
                {
                   //karakter szelektor
                    Console.Write($"{betu}");
                    if (j == 15)
                    {
                        Console.Write("\n\t");
                    }
                }
            }

        }
    }
}