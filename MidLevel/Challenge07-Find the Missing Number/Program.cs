// Find the Missing Number: Write a function that finds the missing number in an array containing numbers from 1 to n.

using System;

class Challenge17{
    static void Main(string[] args){
        int [] numbers = [3, 7, 1, 2, 8, 4, 5];

        for(int i = 1; i <= numbers.Length; i++){
            if(!numbers.Contains(i)){
                Console.WriteLine("Numero que falta: "+i);
            }
        }
    }
}