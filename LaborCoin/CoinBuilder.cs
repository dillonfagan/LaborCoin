namespace LaborCoin
{
	public class CoinBuilder
	{
		private Issuer _issuer;
		private Recipient _recipient;

		private string _laborDescription;
		private float _laborHours;
		private Product _equivalentProduct = Product.None;

		public CoinBuilder From(Issuer issuer)
		{
			_issuer = issuer;
			return this;
		}

		public CoinBuilder To(Recipient recipient)
		{
			_recipient = recipient;
			return this;
		}

		public CoinBuilder WithLaborDescription(string description)
		{
			_laborDescription = description;
			return this;
		}

		public CoinBuilder WithLaborHours(float hours)
		{
			_laborHours = hours;
			return this;
		}

		public CoinBuilder WithEquivalentProduct(string productDescription)
		{
			_equivalentProduct = new Product(productDescription);
			return this;
		}

		public Coin Build()
		{
			var laborAgreement = new LaborAgreement(_laborDescription, _laborHours, _equivalentProduct);
			return new Coin(_issuer, _recipient, laborAgreement);
		}
	}
}