namespace PushDownAutomata.Analyzer
{
	public interface ILanguageAnalyzer
	{
		/// <summary>
		/// Analyzes the input and checks whether it is accepted or not.
		/// </summary>
		/// <param name="input"> Input to be analyzed. </param>
		/// <returns> True or False </returns>
		bool analyze(string input);
	}
}

