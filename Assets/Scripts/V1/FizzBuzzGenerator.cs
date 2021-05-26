using System;

namespace FizzBuzz.V1
{
	public class FizzBuzzGenerator : FizzBuzzGeneratorBase
	{
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
				_rangeFizzBuzzStringBuilder.Append(GenerateFizzBuzzForValue(i));
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
		private string GenerateFizzBuzzForValue(int value) => (value % 3, value % 5) switch
		{
			(0, 0) => "FizzBuzz",
			(0, _) => "Fizz",
			(_, 0) => "Buzz",
			_ => value.ToString()
		};

		#endregion
	}
}
