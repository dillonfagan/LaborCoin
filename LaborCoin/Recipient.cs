namespace LaborCoin
{
	public class Recipient : IPerson
	{
		public Id Id { get; }
		public string Name { get; }
		public CoinCollection ReceivedCoins { get; }

		public Recipient(string name)
		{
			Id = new Id();
			Name = name.ToUpper();
			ReceivedCoins = new CoinCollection();
		}

		public void Redeem(Coin coin)
		{
			ReceivedCoins.Remove(coin);
		}
	}
}