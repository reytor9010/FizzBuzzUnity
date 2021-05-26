using System.Collections;

using NUnit.Framework;

namespace FizzBuzzTest
{
	public class FizzBuzzGeneratorTestCases
	{
		#region Public Constructors

		public FizzBuzzGeneratorTestCases()
		{

		}

		#endregion

		#region Public Static Methods

		#region Invalid Range Test Cases

		public static IEnumerable GenerateFizzBuzzForRange_InvalidStringRange_TestCases
		{
			get
			{
				yield return new TestCaseData("", "");
				yield return new TestCaseData("", "empty");
				yield return new TestCaseData("rafa el", "");
				yield return new TestCaseData("empty", "rafa el");
				yield return new TestCaseData(" ", "_");
				yield return new TestCaseData("0.5 a", "2.6 *");
				yield return new TestCaseData("p 0.3", "n 6.2");
				yield return new TestCaseData("x 2.5 d", "z 7.6 v");
				yield return new TestCaseData("r2.5g", "c7.6p");
			}
		}

		public static IEnumerable GenerateFizzBuzzForRange_InvalidFloatRange_TestCases
		{
			get
			{
				yield return new TestCaseData(1.4f, 0.2f);
				yield return new TestCaseData(-1.5f, -5.5f);
				yield return new TestCaseData(6.8f, 2.3f);
				yield return new TestCaseData(-4.9f, -6.5f);
			}
		}

		public static IEnumerable GenerateFizzBuzzForRange_InvalidIntRange_TestCases
		{
			get
			{
				yield return new TestCaseData(1, 0);
				yield return new TestCaseData(-1, -5);
				yield return new TestCaseData(6, 2);
				yield return new TestCaseData(-4, -6);
			}
		}

		public static IEnumerable Range_InvalidStringRange_TestCases
		{
			get
			{
				yield return new TestCaseData("", "");
				yield return new TestCaseData("", "empty");
				yield return new TestCaseData("r2.5g", "c7.6p");
				yield return new TestCaseData("15", "10");
				yield return new TestCaseData("5.2", "3.1");
				yield return new TestCaseData("5.2 15", "15 3.1");
			}
		}

		public static IEnumerable Range_InvalidFloatRange_TestCases
		{
			get
			{
				yield return new TestCaseData(1.4f, 0.2f);
				yield return new TestCaseData(-1.5f, -5.5f);
				yield return new TestCaseData(6.8f, 2.3f);
				yield return new TestCaseData(-4.9f, -6.5f);
			}
		}

		public static IEnumerable Range_InvalidIntRange_TestCases
		{
			get
			{
				yield return new TestCaseData(1, 0);
				yield return new TestCaseData(-1, -5);
				yield return new TestCaseData(6, 2);
				yield return new TestCaseData(-4, -6);
			}
		}

		#endregion

		#region Valid Range Test Cases

		public static IEnumerable GenerateFizzBuzzForRange_ValidStringRange_TestCases
		{
			get
			{
				yield return new TestCaseData("0.2", "0.5") { ExpectedResult = "FizzBuzz" };
				yield return new TestCaseData("-5.4", "0.1") { ExpectedResult = "Buzz\n-4\nFizz\n-2\n-1\nFizzBuzz" };
				yield return new TestCaseData(" 0.3", "1.8") { ExpectedResult = "FizzBuzz\n1\n2" };
				yield return new TestCaseData("1.1", "1.5 ") { ExpectedResult = "1\n2" };
				yield return new TestCaseData("0.8", " 2.6 ") { ExpectedResult = "1\n2\nFizz" };
				yield return new TestCaseData("3.9", "5.2") { ExpectedResult = "4\nBuzz" };
				yield return new TestCaseData("1.2  ", "5.3") { ExpectedResult = "1\n2\nFizz\n4\nBuzz" };
				yield return new TestCaseData("  1.4", "10.5") { ExpectedResult = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz" };
				yield return new TestCaseData("0.6", "  15.2") { ExpectedResult = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz" };
			}
		}

		public static IEnumerable GenerateFizzBuzzForRange_ValidFloatRange_TestCases
		{
			get
			{
				yield return new TestCaseData(0.2f, 0.5f) { ExpectedResult = "FizzBuzz" };
				yield return new TestCaseData(-5.4f, 0.1f) { ExpectedResult = "Buzz\n-4\nFizz\n-2\n-1\nFizzBuzz" };
				yield return new TestCaseData(0.3f, 1.8f) { ExpectedResult = "FizzBuzz\n1\n2" };
				yield return new TestCaseData(1.1f, 1.5f) { ExpectedResult = "1\n2" };
				yield return new TestCaseData(0.8f, 2.6f) { ExpectedResult = "1\n2\nFizz" };
				yield return new TestCaseData(3.9f, 5.2f) { ExpectedResult = "4\nBuzz" };
				yield return new TestCaseData(1.2f, 5.3f) { ExpectedResult = "1\n2\nFizz\n4\nBuzz" };
				yield return new TestCaseData(1.4f, 10.5f) { ExpectedResult = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz" };
				yield return new TestCaseData(0.6f, 15.2f) { ExpectedResult = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz" };
			}
		}

		public static IEnumerable GenerateFizzBuzzForRange_ValidIntRange_TestCases
		{
			get
			{
				yield return new TestCaseData(0, 0) { ExpectedResult = "FizzBuzz" };
				yield return new TestCaseData(-5, 0) { ExpectedResult = "Buzz\n-4\nFizz\n-2\n-1\nFizzBuzz" };
				yield return new TestCaseData(0, 2) { ExpectedResult = "FizzBuzz\n1\n2" };
				yield return new TestCaseData(1, 2) { ExpectedResult = "1\n2" };
				yield return new TestCaseData(1, 3) { ExpectedResult = "1\n2\nFizz" };
				yield return new TestCaseData(4, 5) { ExpectedResult = "4\nBuzz" };
				yield return new TestCaseData(1, 5) { ExpectedResult = "1\n2\nFizz\n4\nBuzz" };
				yield return new TestCaseData(1, 10) { ExpectedResult = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz" };
				yield return new TestCaseData(1, 15) { ExpectedResult = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz" };
			}
		}

		public static IEnumerable Range_ValidStringRange_TestCases
		{
			get
			{
				yield return new TestCaseData("0.2", "0.5") { ExpectedResult = "[0, 0]" };
				yield return new TestCaseData("-5.4", "0.1") { ExpectedResult = "[-5, 0]" };
				yield return new TestCaseData(" 0.3", "1.8") { ExpectedResult = "[0, 2]" };
				yield return new TestCaseData("1.1", "1.5 ") { ExpectedResult = "[1, 2]" };
				yield return new TestCaseData("0.8", " 2.6 ") { ExpectedResult = "[1, 3]" };
				yield return new TestCaseData("3.9", "5.2") { ExpectedResult = "[4, 5]" };
				yield return new TestCaseData("1.2  ", "5.3") { ExpectedResult = "[1, 5]" };
				yield return new TestCaseData("  1.4", "10.5") { ExpectedResult = "[1, 10]" };
				yield return new TestCaseData("0.6", "  15.2") { ExpectedResult = "[1, 15]" };
			}
		}

		public static IEnumerable Range_ValidFloatRange_TestCases
		{
			get
			{
				yield return new TestCaseData(0.2f, 0.5f) { ExpectedResult = "[0, 0]" };
				yield return new TestCaseData(-5.4f, 0.1f) { ExpectedResult = "[-5, 0]" };
				yield return new TestCaseData(0.3f, 1.8f) { ExpectedResult = "[0, 2]" };
				yield return new TestCaseData(1.1f, 1.5f) { ExpectedResult = "[1, 2]" };
				yield return new TestCaseData(0.8f, 2.6f) { ExpectedResult = "[1, 3]" };
				yield return new TestCaseData(3.9f, 5.2f) { ExpectedResult = "[4, 5]" };
				yield return new TestCaseData(1.2f, 5.3f) { ExpectedResult = "[1, 5]" };
				yield return new TestCaseData(1.4f, 10.5f) { ExpectedResult = "[1, 10]" };
				yield return new TestCaseData(0.6f, 15.2f) { ExpectedResult = "[1, 15]" };
			}
		}

		public static IEnumerable Range_ValidIntRange_TestCases
		{
			get
			{
				yield return new TestCaseData(0, 0) { ExpectedResult = "[0, 0]" };
				yield return new TestCaseData(-5, 0) { ExpectedResult = "[-5, 0]" };
				yield return new TestCaseData(0, 2) { ExpectedResult = "[0, 2]" };
				yield return new TestCaseData(1, 2) { ExpectedResult = "[1, 2]" };
				yield return new TestCaseData(1, 3) { ExpectedResult = "[1, 3]" };
				yield return new TestCaseData(4, 5) { ExpectedResult = "[4, 5]" };
				yield return new TestCaseData(1, 5) { ExpectedResult = "[1, 5]" };
				yield return new TestCaseData(1, 10) { ExpectedResult = "[1, 10]" };
				yield return new TestCaseData(1, 15) { ExpectedResult = "[1, 15]" };
			}
		}

		#endregion

		#endregion
	}
}