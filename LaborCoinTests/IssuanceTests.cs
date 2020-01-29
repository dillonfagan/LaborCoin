using LaborCoin;
using NUnit.Framework;

namespace LaborCoinTests
{
	public class IssuanceTests
	{
		private Issuer Issuer;

		[SetUp]
		public void SetUp()
		{
			Issuer = new Issuer("John Smith");
		}

		[Test]
		public void Given_Issuer_IssuerIssuesCoinWithDescription()
		{
			Coin coin = Issuer.NewCoin()
				.To(new Recipient("Jane Smith"))
				.WithLaborDescription("painting")
				.WithLaborHours(3)
				.Issue();

			Assert.AreEqual(coin.Description, "3 HOURS of PAINTING due to JANE SMITH from JOHN SMITH");
		}

		[Test]
		public void Given_Issuer_IssuerIssuesCoinWithDescription1()
		{
			Coin coin = Issuer.NewCoin()
				.To(new Recipient("Jane Smith"))
				.WithLaborDescription("painting")
				.WithLaborHours(3)
				.Issue();

			Assert.AreEqual(coin.Description, "3 HOURS of PAINTING due to JANE SMITH from JOHN SMITH");
		}

		[Test]
		public void Issue()
		{
			Coin _ = Issuer.NewCoin()
				.To(new Recipient("Jane Smith"))
				.WithLaborDescription("painting")
				.WithLaborHours(3)
				.WithEquivalentProduct("2 pounds of pasta")
				.Issue();

			Assert.AreEqual(Issuer.IssuedCoins.Count, 1);
		}

		[Test]
		public void Receive()
		{
			var recipient = new Recipient("Jane Smith");
			Coin _ = Issuer.NewCoin()
				.To(recipient)
				.WithLaborDescription("painting")
				.WithLaborHours(3)
				.Issue();

			Assert.AreEqual(recipient.ReceivedCoins.Count, 1);
		}
	}
}