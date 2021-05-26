using System;
using System.Text;

namespace FizzBuzz
{
	public abstract class FizzBuzzGeneratorBase : IFizzBuzzGenerator
	{
		#region Private Fields

		/// <summary>
		/// StringBuilder for the generated FizzBuzz result
		/// </summary>
		protected StringBuilder _rangeFizzBuzzStringBuilder;

		#endregion

		#region Public Constructor

		public FizzBuzzGeneratorBase()
		{
			_rangeFizzBuzzStringBuilder = new StringBuilder();
		}

		#endregion

		#region Public Properties

		/// <summary>
		/// Get the FizzBuzz range as a string like [minRangeValue, maxRangeValue]
		/// </summary>
		public virtual string Range { get; protected set; } = string.Empty;

		#endregion

		#region Public Methods

		/// <summary>
		/// Generate the FizzBuzz message for all the values in an inclusive range [string <paramref name="minRangeValue"/>, string <paramref name="maxRangeValue"/>] separated by a new line.
		/// </summary>
		/// <param name="minRangeValue"></param>
		/// <param name="maxRangeValue"></param>
		public virtual string GenerateFizzBuzzForRange(string minRangeValue, string maxRangeValue)
		{
			if (float.TryParse(minRangeValue, out float minValue) && float.TryParse(maxRangeValue, out float maxValue))
			{
				return GenerateFizzBuzzForRange(minValue, maxValue);
			}
			else
			{
				Range = string.Empty;
				throw new ArgumentException("Invalid range");
			}
		}

		/// <summary>
		/// Generate the FizzBuzz message for all the values in an inclusive range [float <paramref name="minRangeValue"/>, float <paramref name="maxRangeValue"/>] separated by a new line.
		/// </summary>
		/// <param name="minRangeValue"></param>
		/// <param name="maxRangeValue"></param>
		public virtual string GenerateFizzBuzzForRange(float minRangeValue = 1, float maxRangeValue = 100)
		{
			return GenerateFizzBuzzForRange((int)Math.Round(minRangeValue), (int)Math.Round(maxRangeValue));
		}

		/// <summary>
		/// Generate the FizzBuzz message for all the values in an inclusive range [int <paramref name="minRangeValue"/>, int <paramref name="maxRangeValue"/>] separated by a new line.
		/// </summary>
		/// <param name="minRangeValue"></param>
		/// <param name="maxRangeValue"></param>
		public abstract string GenerateFizzBuzzForRange(int minRangeValue = 1, int maxRangeValue = 100);

		#endregion
	}
}
