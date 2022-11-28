using System;
using System.Runtime.InteropServices;

namespace PushDownAutomata.Analyzer
{
	public class PalindromeAnalyzer : ILanguageAnalyzer
	{
        Stack<char> stack = new Stack<char>();

        public bool Analyze(string input)
        {
            if (input.Length % 2 != 0)
            {
                input = input.Remove(input.Length / 2, 1);
            }
            for (int i = 0; i < input.Length; i++)
            {
                var current = input[i];
                if (!stack.Contains(current))
                {
                    stack.Push(current);
                }
                else 
                {
                    var top = stack.Pop();
                    if (top != current)
                    {
                        return false;
                    }
                }
            }
            if (stack.Count != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

