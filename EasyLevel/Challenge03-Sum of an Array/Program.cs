// Sum of an Array: Write a function that takes an array of integers and returns the sum of all the elements.

using System;
using System.Linq;

public class Challenge3{
    public static void Main(string[] args){
        Console.WriteLine("Ingresa 10 numeros separandolos mediante un enter");
        int [] numbers = new int[10];
        int aux = 0;
        for(int i = 0; i < 10; i++){
            string stringInNums = Console.ReadLine();
            int num = int.Parse(stringInNums); 
            numbers[i] = num;
            // Sin linq
            aux += num;
        }
        Console.WriteLine("La suma de los numeros da: " + aux);
    }
}