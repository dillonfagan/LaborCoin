using LaborCoin;
using LaborCoinTests.Objects;
using NUnit.Framework;

namespace LaborCoinTests
{
	public class CoinTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Given_Coin_IssuerHasName()
		{
			Coin coin = CoinMother.CreateCoin();

			Assert.That(coin.Issuer.Name, Is.EqualTo("JOHN SMITH"));
		}

		[Test]
		public void Given_TwoCoinsFromSameIssuer_CoinsHaveDifferentIds()
		{
			Coin coin1 = CoinMother.CreateCoin();
			Coin coin2 = CoinMother.CreateCoin();

			Assert.AreNotEqual(coin1.Id.ToString(), coin2.Id.ToString());
		}

		[Test]
		public void Given_Coin_LaborAgreementHasDescription()
		{
			Coin coin = CoinMother.CreateCoin_3Hours_Painting();

			Assert.AreEqual(coin.Labor.Description, "PAINTING");
		}

		[Test]
		public void Given_Coin_LaborAgreementHasHours()
		{
			Coin coin = CoinMother.CreateCoin_3Hours_Painting();

			Assert.AreEqual(coin.Labor.Hours, 3);
		}

		[Test]
		public void Given_Coin_LaborAgreementHasStringRepresentation()
		{
			Coin coin = CoinMother.CreateCoin_3Hours_Painting();

			Assert.AreEqual(coin.Labor.ToString(), "3 HOURS of PAINTING");
		}

		[Test]
		public void Given_TwoIssuersWithSameName_IssuersHaveDifferentIds()
		{
			var issuer1 = new Issuer("John Smith");
			var issuer2 = new Issuer("John Smith");

			Assert.AreNotEqual(issuer1.Id.ToString(), issuer2.Id.ToString());
		}

		[Test]
		public void Given_Coin_CoinHasFullDescription()
		{
			Coin coin = CoinMother.CreateCoin_3Hours_Painting();

			Assert.AreEqual(coin.Description, "3 HOURS of PAINTING due to JANE SMITH from JOHN SMITH");
		}

		[Test]
		public void Given_Coin_CoinHasFullDescription1()
		{
			Coin coin = CoinMother.CreateCoin_3Hours_Painting();

			Assert.AreEqual(coin.Labor.EquivalentProduct.Description, "2 pounds of pasta");
		}
	}
}