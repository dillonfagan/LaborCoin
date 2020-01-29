namespace LaborCoin
{
	public class LaborAgreement
	{
		public string Description { get; }
		public float Hours { get; }
		public Product EquivalentProduct { get; }

		public LaborAgreement(string description, float hours, Product equivalentProduct)
		{
			Description = description.ToUpper();
			Hours = hours;
			EquivalentProduct = equivalentProduct;
		}

		public override string ToString() => $"{Hours} HOURS of {Description}";
	}
}