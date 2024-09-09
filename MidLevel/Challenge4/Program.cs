// String Compression: Implement a function that compresses a string using the counts of repeated characters (e.g., "aabcccccaaa" -> "a2b1c5a3").

using System;
using System.Text;

class Challenge14{
    static void Main(string[] args){
        string oracion = "aabcccccaaa";

        StringCompression(oracion);
    }

    static void StringCompression(string oracion){
        int count = 1;
        var nuevaOracion = new StringBuilder();
        char[] letras = oracion.ToCharArray();
        for(int i = 0; i <= oracion.Length; i++){
            if(i + 1 < letras.Length){
                if(letras[i] == letras[i+1]){
                    count++;
                }else{
                    nuevaOracion.Append(letras[i]);
                    nuevaOracion.Append(count);
                    count = 1;
                }
            }
            if(i == letras.Length){
                nuevaOracion.Append(letras[i - 1]);
                nuevaOracion.Append(count);
            }
        }
        Console.WriteLine(nuevaOracion);
    }
}