using System.Collections;
using System.Collections.Generic;

namespace LaborCoin
{
	public class CoinCollection : IEnumerable<Coin>
	{
		private readonly HashSet<Coin> _coins = new HashSet<Coin>();

		public int Count => _coins.Count;

		public void Add(Coin coin) => _coins.Add(coin);

		public void Remove(Coin coin) => _coins.Remove(coin);

		public IEnumerator<Coin> GetEnumerator() => _coins.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}