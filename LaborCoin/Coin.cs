namespace LaborCoin
{
	public class Coin
	{
		public Id Id { get; }
		public IPerson Issuer { get; }
		public IPerson Recipient { get; }
		public LaborAgreement Labor { get; }
		public string Description => $"{Labor} due to {Recipient.Name} from {Issuer.Name}";

		public Coin(IPerson issuer, IPerson recipient, LaborAgreement laborAgreement)
		{
			Id = new Id();
			Issuer = issuer;
			Recipient = recipient;
			Labor = laborAgreement;
		}
	}
}