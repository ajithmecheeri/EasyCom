using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyCom.Api.Provider.Interfaces;
using EasyCom.Api.Repository.Interfaces;
using EasyCom.Api.Types;

namespace EasyCom.Api.Provider
{
    public class ProductProvider : IProductProvider
    {
        IProductRepository productRepository;

        //public ProductProvider(IProductRepository productRepositoryObj)
        //{
        //    productRepository = productRepositoryObj;
        //}
        public ProductProvider()
        {

        }
        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int productId)
        {
            Product product = new Product();
            product.Price = 500;
            product.ProductID = productId;
            product.ProductName = string.Format("Maggi {0}gms", productId);
            return product;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> productList = new List<Product>();
            for (int index = 0; index < 20; index++)
            {
                Product product = new Product();
                product.Price = 1;
                product.ProductID = index + 1;
                product.ProductName = string.Format("Maggi {0}gms", index + 1);
                productList.Add(product);
            }
            return productList; 
        }

        public List<Product> GetAllProductsWithOffer()
        {
            List<Product> productList = new List<Product>();
            for (int index = 15; index < 20; index++)
            {
                Product product = new Product();
                product.Price = 1;
                product.ProductID = index + 1;
                product.ProductName = string.Format("Maggi {0}gms", index + 1);
                productList.Add(product);
            }
            return productList;
        }

        public void UpdateProduct(Api.Types.Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int productID)
        {
            throw new NotImplementedException();
        }

    }
}
