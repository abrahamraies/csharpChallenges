//Palindrome Check: Write a function to check if a given string is a palindrome (reads the same forward and backward).
using System;

public class Challenge2{
    public static void Main(string[] args){
        string sentence = Console.ReadLine();
        Console.WriteLine(IsPalindrome(sentence));
    }

    static bool IsPalindrome(string sentence){
        char[] sentenceInArray = sentence.ToCharArray();
        Array.Reverse(sentenceInArray);
        return sentence.Equals(new string(sentenceInArray));
    }
}