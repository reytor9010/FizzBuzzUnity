using System;
using System.Text;

namespace FizzBuzz.V2
{
	public class FizzBuzzGenerator : FizzBuzzGeneratorBase
	{
		#region Private Fields

		private StringBuilder _valueFizzBuzzStringBuilder;

		#endregion

		#region Public Constructors

		public FizzBuzzGenerator()
		{
			_valueFizzBuzzStringBuilder = new StringBuilder();
		}

		#endregion

		#region Public Methods

		public override string GenerateFizzBuzzForRange(int minRangeValue = 1, int maxRangeValue = 100)
		{
			if (minRangeValue > maxRangeValue)
			{
				Range = string.Empty;
				throw new ArgumentException("Invalid range");
			}

			Range = $"[{minRangeValue}, {maxRangeValue}]";
			_rangeFizzBuzzStringBuilder.Clear();

			for (int i = minRangeValue; i <= maxRangeValue; i++)
			{
				_valueFizzBuzzStringBuilder.Clear();

				GenerateFizzBuzzForValue(i, _valueFizzBuzzStringBuilder);

				_rangeFizzBuzzStringBuilder.Append(_valueFizzBuzzStringBuilder);
				_rangeFizzBuzzStringBuilder.Append(i < maxRangeValue ? "\n" : "");
			}

			return _rangeFizzBuzzStringBuilder.ToString();
		}

		#endregion

		#region Private Methods

		/// <summary>
		/// Generate the FizzBuzz message for a single value
		/// </summary>
		/// <param name="value"></param>
		private void GenerateFizzBuzzForValue(int value, StringBuilder result)
		{
			result.AppendIfDivisible(value, 3, "Fizz");
			result.AppendIfDivisible(value, 5, "Buzz");

			if (result.Length == 0)
			{
				result.Append(value.ToString());
			}
		}

		#endregion
	}
}
