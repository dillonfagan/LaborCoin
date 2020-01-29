namespace LaborCoin
{
	public class Issuer : IPerson
	{
		public Id Id { get; }
		public string Name { get; }
		public CoinCollection IssuedCoins { get; }

		public Issuer(string name)
		{
			Id = new Id();
			Name = name.ToUpper();
			IssuedCoins = new CoinCollection();
		}

		public CoinIssuer NewCoin() => new CoinIssuer(this);
	}
}