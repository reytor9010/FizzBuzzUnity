using System;

using FizzBuzz;

using NUnit.Framework;

namespace FizzBuzzTest
{
	[TestFixture]
	public abstract class FizzBuzzGeneratorTestBase
	{
		#region Private Fields

		protected IFizzBuzzGenerator _fizzBuzzGenerator;

		#endregion

		#region SetUp

		[SetUp]
		public abstract void SetUp();

		#endregion

		#region Test Methods

		#region Invalid Range Tests

		[TestCaseSource(typeof(FizzBuzzGeneratorTestCases), "GenerateFizzBuzzForRange_InvalidStringRange_TestCases")]
		public virtual void GenerateFizzBuzzForRange_InvalidStringRange_ArgumentException(string minRangeValue, string maxRangeValue)
		{
			Assert.Throws(typeof(ArgumentException), () => _fizzBuzzGenerator.GenerateFizzBuzzForRange(minRangeValue, maxRangeValue));
		}

		[TestCaseSource(typeof(FizzBuzzGeneratorTestCases), "GenerateFizzBuzzForRange_InvalidFloatRange_TestCases")]
		public virtual void GenerateFizzBuzzForRange_InvalidFloatRange_ArgumentException(float minRangeValue, float maxRangeValue)
		{
			Assert.Throws(typeof(ArgumentException), () => _fizzBuzzGenerator.GenerateFizzBuzzForRange(minRangeValue, maxRangeValue));
		}

		[TestCaseSource(typeof(FizzBuzzGeneratorTestCases), "GenerateFizzBuzzForRange_InvalidIntRange_TestCases")]
		public virtual void GenerateFizzBuzzForRange_InvalidIntRange_ArgumentException(float minRangeValue, float maxRangeValue)
		{
			Assert.Throws(typeof(ArgumentException), () => _fizzBuzzGenerator.GenerateFizzBuzzForRange(minRangeValue, maxRangeValue));
		}

		[TestCaseSource(typeof(FizzBuzzGeneratorTestCases), "Range_InvalidStringRange_TestCases")]
		public virtual void Range_InvalidStringRange_Empty(string minRangeValue, string maxRangeValue)
		{
			Assert.IsEmpty(_fizzBuzzGenerator.Range);
		}

		[TestCaseSource(typeof(FizzBuzzGeneratorTestCases), "Range_InvalidFloatRange_TestCases")]
		public virtual void Range_InvalidFloatRange_Empty(float minRangeValue, float maxRangeValue)
		{
			Assert.IsEmpty(_fizzBuzzGenerator.Range);
		}

		[TestCaseSource(typeof(FizzBuzzGeneratorTestCases), "Range_InvalidIntRange_TestCases")]
		public virtual void Range_InvalidIntRange_Empty(float minRangeValue, float maxRangeValue)
		{
			Assert.IsEmpty(_fizzBuzzGenerator.Range);
		}

		#endregion

		#region Valid Range Tests

		[TestCaseSource(typeof(FizzBuzzGeneratorTestCases), "GenerateFizzBuzzForRange_ValidStringRange_TestCases")]
		public virtual string GenerateFizzBuzzForRange_ValidStringRange_FizzBuzzMessage(string minRangeValue, string maxRangeValue)
		{
			return _fizzBuzzGenerator.GenerateFizzBuzzForRange(minRangeValue, maxRangeValue);
		}

		[TestCaseSource(typeof(FizzBuzzGeneratorTestCases), "GenerateFizzBuzzForRange_ValidFloatRange_TestCases")]
		public virtual string GenerateFizzBuzzForRange_ValidFloatRange_FizzBuzzMessage(float minRangeValue, float maxRangeValue)
		{
			return _fizzBuzzGenerator.GenerateFizzBuzzForRange(minRangeValue, maxRangeValue);
		}

		[TestCaseSource(typeof(FizzBuzzGeneratorTestCases), "GenerateFizzBuzzForRange_ValidIntRange_TestCases")]
		public virtual string GenerateFizzBuzzForRange_ValidIntRange_FizzBuzzMessage(float minRangeValue, float maxRangeValue)
		{
			return _fizzBuzzGenerator.GenerateFizzBuzzForRange(minRangeValue, maxRangeValue);
		}

		[TestCaseSource(typeof(FizzBuzzGeneratorTestCases), "Range_ValidStringRange_TestCases")]
		public virtual string Range_ValidStringRange_Empty(string minRangeValue, string maxRangeValue)
		{
			_fizzBuzzGenerator.GenerateFizzBuzzForRange(minRangeValue, maxRangeValue);

			return _fizzBuzzGenerator.Range;
		}

		[TestCaseSource(typeof(FizzBuzzGeneratorTestCases), "Range_ValidFloatRange_TestCases")]
		public virtual string Range_ValidFloatRange_Empty(float minRangeValue, float maxRangeValue)
		{
			_fizzBuzzGenerator.GenerateFizzBuzzForRange(minRangeValue, maxRangeValue);

			return _fizzBuzzGenerator.Range;
		}

		[TestCaseSource(typeof(FizzBuzzGeneratorTestCases), "Range_ValidIntRange_TestCases")]
		public virtual string Range_ValidIntRange_Empty(float minRangeValue, float maxRangeValue)
		{
			_fizzBuzzGenerator.GenerateFizzBuzzForRange(minRangeValue, maxRangeValue);

			return _fizzBuzzGenerator.Range;
		}

		#endregion

		#endregion
	}
}