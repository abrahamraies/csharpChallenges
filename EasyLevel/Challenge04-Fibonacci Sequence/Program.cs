// Fibonacci Sequence: Write a function to generate the first n numbers in the Fibonacci sequence.

using System;

public class Challenge4
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingresa la cantidad de numeros de la secuencia de Fibonacci que quieres ver: ");
        int num = int.Parse(Console.ReadLine());
        int num1 = 0, num2 = 1, nextNumber = 0;
        if (num <= 0)
        {
            Console.WriteLine("La cantidad de numeros no puede ser negativa o nula");
        }
        else
        {
            FibonacciFunction(num,num1,num2,nextNumber);
            Console.WriteLine("");
            FibonacciRecursiveFunction(num,0,1,1);
        }
    }

    // Iterative
    static void FibonacciFunction(int num, int num1, int num2, int nextNumber)
    {
        if (num == 1)
        {
            Console.Write("0");
        }
        else
        {
            Console.Write(num1 + " " + num2 + " ");
            for(int i = 2; i < num; i++){
                nextNumber = num1 + num2;
                Console.Write(nextNumber + " ");
                num1 = num2;
                num2 = nextNumber;
            }
        }
    }

    //Recursive
    static void FibonacciRecursiveFunction(int num,int num1,int num2,int aux){
        Console.Write(num1 + " ");
        if(aux < num){
            FibonacciRecursiveFunction(num, num2, num1+num2,aux+1);
        }
    }
}