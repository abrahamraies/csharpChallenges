// Two Sum Problem: Write a function that finds two numbers in an array that add up to a specific target.

using System;

class Challenge20{
    static void Main(string[] args){
        int [] array1 = [1,2,3,4,5];

        Console.WriteLine("Ingresa el numero a ser obtenido: ");
        int numero = int.Parse(Console.ReadLine());

        var result = FindTwoSum(array, numero);

        if(result != null){
            Console.WriteLine("Los números que suman " + numero + " son: " + result[0] + " y " + result[1]);
        } else {
            Console.WriteLine("No se encontraron dos números que sumen " + numero);
        }
    }

        static int[] FindTwoSum(int[] array, int target){
        Dictionary<int, int> map = new Dictionary<int, int>();

        for(int i = 0; i < array.Length; i++){
            int complement = target - array[i];

            if(map.ContainsKey(complement)){
                return new int[] {complement, array[i]};
            }

            if(!map.ContainsKey(array[i])){
                map.Add(array[i], i);
            }
        }

        return null;
    }
}