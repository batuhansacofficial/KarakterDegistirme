using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Bir ifade giriniz: ");
        string input = Console.ReadLine();
        
        string output = string.Join(" ", input.Split(' ')
            .Select(kelime => KarakterSwap(kelime)));
        
        Console.WriteLine("ÇIKTI: " + output);
    }

    static string KarakterSwap(string kelime)
    {
        if (kelime.Length <= 1)
            return kelime;

        char[] karakter = kelime.ToCharArray();
        (karakter[0], karakter[^1]) = (karakter[^1], karakter[0]);

        return new string(karakter);
    }
}