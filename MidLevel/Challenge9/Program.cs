// Sum of Digits: Write a function to return the sum of the digits of a given integer.

using System;
class Challenge19
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingresa un numero: ");
        int numero = int.Parse(Console.ReadLine());

        var numberInArray = numero.ToString().Select(x => (int)char.GetNumericValue(x)).ToArray();

        Console.WriteLine(numberInArray.Sum());

        // do
        // {
        //     yield return number % 10;
        //     number /= 10;
        // } while (number > 0);
    }
}