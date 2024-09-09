// Count Vowels: Write a function that counts the number of vowels in a given string.

using System;

public class Challenge8{
    public static void Main(string[] args){
        int aux = 0;
        char[] vowels = {'a','e','i','o','u'};
        Console.WriteLine("Ingresa una oracion");
        string sentence = Console.ReadLine();
        char [] sentenceInArray = sentence.ToCharArray();
        foreach(char word in sentenceInArray){
            foreach(char vowel in vowels){
                if(word == vowel){
                    aux++;
                    break;
                }
            }
        }
        Console.WriteLine("La cantidad de vocales en la oracion es: " + aux);
    }
}