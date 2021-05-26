using FizzBuzz.V2;

using NUnit.Framework;

namespace FizzBuzzTest.V2
{
	[TestFixture]
	public class FizzBuzzGeneratorTest : FizzBuzzGeneratorTestBase
	{
		#region SetUp

		[SetUp]
		public override void SetUp()
		{
			_fizzBuzzGenerator = new FizzBuzzGenerator();
		}

		#endregion
	}
}