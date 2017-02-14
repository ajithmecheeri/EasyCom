using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyCom.Api.Types;

namespace EasyCom.Api.Repository.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        Product GetProductByID();
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productID);
    }
}
