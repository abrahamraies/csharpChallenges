// Merge Two Arrays: Write a function to merge two arrays into one without duplicates.
using System;
using System.Linq;

public class Challenge9{
    public static void Main(string[] args){
        int [] array1 = {1,2,3,4,6,8};
        int [] array2 = {3,4,5,6,7,9};
        int [] result = array1.Union(array2).ToArray();
        foreach(int num in result){
            Console.Write(num);
        }        
    }
}