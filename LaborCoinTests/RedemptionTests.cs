using System.Linq;
using LaborCoin;
using NUnit.Framework;

namespace LaborCoinTests
{
	public class RedemptionTests
	{
		[Test]
		public void Cheese()
		{
			var Issuer = new Issuer("John Smith");
			var recipient = new Recipient("Jane Smith");
			Coin _ = Issuer.NewCoin()
				.To(recipient)
				.WithLaborDescription("painting")
				.WithLaborHours(3)
				.Issue();

			recipient.Redeem(recipient.ReceivedCoins.First());

			Assert.IsEmpty(recipient.ReceivedCoins);
		}
	}
}