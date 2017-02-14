using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyCom.Api.Types;

namespace EasyCom.Api.Provider.Interfaces
{
    public interface IProductProvider
    {
        Product GetProduct(int productId);
        List<Product> GetAllProducts();
        List<Product> GetAllProductsWithOffer();
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productID);
    }
}
