namespace LaborCoin
{
	public class CoinIssuer
	{
		private CoinBuilder _builder = new CoinBuilder();
		private readonly Issuer _issuer;
		private Recipient _recipient;

		public CoinIssuer(Issuer issuer)
		{
			_issuer = issuer;
			_builder = _builder.From(issuer);
		}

		public CoinIssuer To(Recipient recipient)
		{
			_recipient = recipient;
			_builder = _builder.To(recipient);
			return this;
		}

		public CoinIssuer WithLaborDescription(string description)
		{
			_builder = _builder.WithLaborDescription(description);
			return this;
		}

		public CoinIssuer WithLaborHours(float hours)
		{
			_builder = _builder.WithLaborHours(hours);
			return this;
		}

		public CoinIssuer WithEquivalentProduct(string productDescription)
		{
			_builder = _builder.WithEquivalentProduct(productDescription);
			return this;
		}

		public Coin Issue()
		{
			Coin coin = _builder.Build();
			_issuer.IssuedCoins.Add(coin);
			_recipient.ReceivedCoins.Add(coin);

			return coin;
		}
	}
}