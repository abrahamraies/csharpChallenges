// Factorial Calculation: Write a function to calculate the factorial of a given number.

using System;

public class Challenge5{
    public static void Main (string[] args){
        Console.WriteLine("Ingresa un numero para calcular su factorial: ");
        int num = int.Parse(Console.ReadLine());

        CalculateFunctional(num);
    }

    static void CalculateFunctional(int num){
        int aux = 1;
        for(int i = 1; i < num; i++){
            aux *= i;
        }
        Console.WriteLine("Su factorial es: " + aux);
    }
}