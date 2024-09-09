// Balanced Parentheses: Write a function to check if a string has balanced parentheses.

using System;

class Challenge18{
    static void Main(string[] args){
        string palabra1 = "Cuantos( parentesis tendrá ))())()";
        string palabra2 = "Parentesis balanceados )(()())(";
        Console.WriteLine("Paréntesis balanceados: " + AreParenthesesBalanced(palabra1));
    }

        static bool AreParenthesesBalanced(string input){
        Stack<char> stack = new Stack<char>();

        foreach (char c in input){
            if (c == '('){
                stack.Push(c);
            } else if (c == ')'){
                if (stack.Count == 0){
                    return false;
                }
                stack.Pop();
            }
        }

        return stack.Count == 0;
    }
}