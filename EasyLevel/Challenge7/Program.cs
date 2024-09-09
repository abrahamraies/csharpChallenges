// Find the Maximum: Write a function that finds and returns the maximum value in an array of integers.

using System;
using System.Linq;

public class Challenge7{
    public static void Main(string[] args){
        int[] numbers = {0,1,2,4,43,42,46,8,99,56,421,46,43,7,864,854,34,56547};
        Console.WriteLine("The max number is: " + numbers.Max());
    }
}