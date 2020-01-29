using LaborCoin;

namespace LaborCoinTests.Objects
{
	internal static class CoinMother
	{
		public static Coin CreateCoin()
		{
			return new CoinBuilder()
				.From(new Issuer("John Smith"))
				.To(new Recipient("Jane Smith"))
				.WithLaborDescription(string.Empty)
				.WithLaborHours(1)
				.Build();
		}

		public static Coin CreateCoin_3Hours_Painting()
		{
			return new CoinBuilder()
				.From(new Issuer("John Smith"))
				.To(new Recipient("Jane Smith"))
				.WithLaborDescription("painting")
				.WithLaborHours(3)
				.WithEquivalentProduct("2 pounds of pasta")
				.Build();
		}
	}
}