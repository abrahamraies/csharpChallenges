// Even or Odd: Write a function that takes an integer and returns "Even" if it's even and "Odd" if it's odd.
using System;

public class ChallengeOne
{
    public static void Main(string[] args){
        Console.WriteLine("Ingresa un numero: ");
        string number = Console.ReadLine();
        int num = int.Parse(number);
        Console.WriteLine(EvenOrOdd(num));
    }

    static string EvenOrOdd(int num){
        if(num % 2 == 0){
            return "Even";
        }else{
            return "Odd";
        }
    }
}