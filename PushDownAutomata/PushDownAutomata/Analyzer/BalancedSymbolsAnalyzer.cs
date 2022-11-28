namespace PushDownAutomata.Analyzer
{
	public class BalancedSymbolsAnalyzer : ILanguageAnalyzer
	{
        Stack<char> stack = new Stack<char>(); 

        public bool Analyze(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                var current = input[i];
                if (current == '(' || current == '[' || current == '{')
                {
                    stack.Push(current);
                }
                else if (current == ')' || current == ']' || current == '}')
                {
                    var top = stack.Pop();

                    if (top == '(')
                    {
                        if (current != ')')
                            return false;
                    }
                    else if (top == '{')
                    {
                        if (current != '}')
                            return false;
                    }
                    else if (top == '[')
                    {
                        if (current != ']')
                            return false;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
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

