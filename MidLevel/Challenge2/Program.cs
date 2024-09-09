// Remove Duplicates: Write a function that removes duplicate numbers from an array.
using System;
using System.Linq;
class Challenge12{
    static void Main(string[] args){
        int [] nums = [1,2,3,4,5,6,1,2,5,6,4,7];
        nums = nums.Distinct().ToArray();
        foreach(int num in nums){
            Console.Write(num);
        }
    }
}