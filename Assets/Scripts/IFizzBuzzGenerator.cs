namespace FizzBuzz
{
	public interface IFizzBuzzGenerator
	{
		string Range { get; }

		string GenerateFizzBuzzForRange(string minRangeValue, string maxRangeValue);
		string GenerateFizzBuzzForRange(float minRangeValue, float maxRangeValue);
		string GenerateFizzBuzzForRange(int minRangeValue, int maxRangeValue);
	}
}