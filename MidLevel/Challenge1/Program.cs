// Prime Number Check: Write a function to check if a given number is a prime number.
using System;

class Challenge11{
    static void Main(string[] args){
        Console.WriteLine("Ingresa un numero: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(num));
    }

    static bool IsPrime(int num){
        bool isPrime = true;
        for(int i = 2; i < num/2; i++){
            if(num % i == 0){
                isPrime = false;
                break;
            }
        }
        return isPrime;
    }
}