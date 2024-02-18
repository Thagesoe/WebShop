using WebShop.ViewModels;

namespace WebShop.Extensions
{
	public static class ProductVmExtensions
	{
		public static ProductVm CalcPrice(this ProductVm product)
		{
			switch (product)
			{
				case var p when p.StockQuantity > 20:
					p.Price *= 0.9;
					break;
				case var p when p.StockQuantity < 5:
					p.Price *= 1.2;
					break;
			}
			return product;
		}
	}
}
