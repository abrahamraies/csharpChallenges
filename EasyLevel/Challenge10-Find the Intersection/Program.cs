//Find the Intersection: Given two arrays, write a function that returns an array of their intersection (common elements).
using System;
using System.Linq;

public class Challenge10{
    public static void Main(string[] args){
        int [] array1 = {1,2,3,4,6,8};
        int [] array2 = {3,4,5,6,7,9};
        int [] result = array1.Intersect(array2).ToArray();
        foreach(int num in result){
            Console.Write(num);
        }    
    }
}