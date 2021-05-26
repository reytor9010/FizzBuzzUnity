using FizzBuzz.V1;

using NUnit.Framework;

namespace FizzBuzzTest.V1
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