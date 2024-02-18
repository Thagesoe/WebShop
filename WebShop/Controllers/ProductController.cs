using Database;
using Database.Tables;
using AutoMapper;
using WebShop.Extensions;
using WebShop.ViewModels;

namespace WebShop.Controllers
{
	public class ProductController  {
		private readonly Products _database;
		private readonly IMapper _mapper;

		public ProductController() {
			_database = new Products();
			var config = new MapperConfiguration(cfg => {
				cfg.CreateMap<Product, ProductVm>();
			});
			_mapper = config.CreateMapper();
		}
		public IEnumerable<ProductVm> GetProducts() {
			var products = _database.GetProducts();
			var productsVm = _mapper.Map<IEnumerable<ProductVm>>(products)
			                        .Select(p => p.CalcPrice());
			return productsVm;
		}

		public ProductVm? GetProduct(int id) {
			return _mapper.Map<ProductVm>(_database.GetProduct(id))
			              .CalcPrice();
		}

		public void AddProduct(ProductVm product) {
			_database.AddProduct(_mapper.Map<Product>(product));
		}

		public void UpdateProduct(ProductVm product) {
			var prod =  _mapper.Map<ProductVm>(_database.GetProduct(product.Id));
			if(prod == null) return;
			_database.UpdateProduct(_mapper.Map<Product>(product));
		}

		public void DeleteProduct(int id) {
			_database.DeleteProduct(id);
		}

	}
}
