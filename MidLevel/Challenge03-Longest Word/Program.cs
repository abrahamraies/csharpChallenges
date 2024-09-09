// Longest Word: Write a function to find the longest word in a given string.

using System;

public class Challenge13{
    static void Main(string[] args){
        Console.WriteLine("Ingresa una oracion");
        string oracion = Console.ReadLine();

        LongestWord(oracion);
    }

    static void LongestWord(string oracion){
        int wordLength = 0;
        string longestWord = "";
        foreach(string word in oracion.Split()){
            if(word.Length > wordLength){
                longestWord = word;
                wordLength = longestWord.Length;
            }
        }
        Console.WriteLine("La palabra mas larga de la oracion es: " + longestWord);
    }
}