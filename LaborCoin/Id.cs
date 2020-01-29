using System;

namespace LaborCoin
{
	public class Id
	{
		private Guid _guid;

		public Id() => _guid = Guid.NewGuid();

		public override string ToString() => _guid.ToString();
	}
}