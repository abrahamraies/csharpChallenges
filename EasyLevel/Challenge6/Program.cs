// Reverse a String: Write a function that takes a string and returns it reversed.
using System;
using System.Linq;
public class Challenge6{
    public static void Main(string[] args){
        string sentence = Console.ReadLine();
        char[] sentenceToArray = sentence.ToCharArray();
        Array.Reverse(sentenceToArray);
        Console.WriteLine(sentenceToArray);
    }
}