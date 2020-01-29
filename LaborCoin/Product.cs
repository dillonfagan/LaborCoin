namespace LaborCoin
{
	public class Product
	{
		public string Description { get; }

		public static Product None => new Product("NONE");

		public Product(string description) => Description = description;
	}
}