using PushDownAutomata.Analyzer;

ILanguageAnalyzer analyzer;
int choice;
do
{
    Console.WriteLine("Choose: ");
    Console.WriteLine("0 - Balance Symbols");
    Console.WriteLine("1 - Palindrome");
    Console.WriteLine("2 - End");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 0:
            Console.WriteLine("Enter a string to check whether it comprises Balance Symbols or not.");
            Console.WriteLine("True -> It is Balanced.");
            Console.WriteLine("False -> It is NOT Balanced.");
            analyzer = new BalancedSymbolsAnalyzer();
            Test(analyzer);
            break;

        case 1:
            Console.WriteLine("Enter a string to check whether it is a Palindrome or not.");
            Console.WriteLine("True -> It is a Palindrome.");
            Console.WriteLine("False -> It is NOT a Palindrome.");
            analyzer = new PalindromeAnalyzer();
            Test(analyzer);
            break;

        case 2:
            Console.WriteLine("Bye bye");
            break;

        default:
            Console.WriteLine("Enter a valid option.");
            break;
    }
} while (choice != 2);

void Test(ILanguageAnalyzer languageAnalyzer)
{
    string? input = Console.ReadLine();
    Console.WriteLine(languageAnalyzer.Analyze(input));
}