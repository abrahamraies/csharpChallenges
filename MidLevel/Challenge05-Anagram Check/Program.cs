// Anagram Check: Write a function to check if two strings are anagrams of each other.

using System;
using System.Linq;

class Challenge15{
    static void Main(string[] args){
        Console.WriteLine("Ingresa dos palabras");
        string palabra1 = Console.ReadLine();
        string palabra2 = Console.ReadLine();

        Console.WriteLine(isAnagram(palabra1, palabra2));
    }

    static bool isAnagram(string palabra1,string palabra2){
        if(palabra1.Length != palabra2.Length)
            return false;

        if(palabra1 == palabra2)
            return true;

        char [] palabra1Array = palabra1.ToCharArray();
        char [] palabra2Array = palabra2.ToCharArray();

        Array.Sort(palabra1Array);
        Array.Sort(palabra2Array);

        return palabra1Array.SequenceEqual(palabra2Array);
    }
}