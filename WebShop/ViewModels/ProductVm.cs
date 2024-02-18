using Database.Tables;

namespace WebShop.ViewModels
{
	public class ProductVm
	{
		public int        Id            { get; set; }
		public string     Name          { get; set; }
		public string     Description   { get; set; }
		public double     Price         { get; set; }
		public int        StockQuantity { get; set; }

		
	}


}
