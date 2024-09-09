// Array Rotation: Write a function to rotate an array to the right by k steps.

using System;

class Challenge16{
    static void Main(string[] args){
        int [] array = [7,8,9];
        Console.WriteLine("Ingresa el numero de posiciones que quieras mover el array");
        int num = int.Parse(Console.ReadLine());
        List<int> lista = array.ToList();

        for(int i = num; i >= 0; i--){
            lista.RemoveAt(i);
        }
        for(int i = 0; i <= num; i++){
            lista.Add(array[i]);
        }
        foreach(int i in lista){
            Console.Write(" " + i);
        }
    }
}