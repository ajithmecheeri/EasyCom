using System.Collections.Generic;
using System.Web.Http;
using EasyCom.Api.Provider;
using EasyCom.Api.Types;
using Microsoft.Practices.Unity;
using EasyCom.Api.Repository.Interfaces;
using EasyCom.Api.Provider.Interfaces;
using EasyCom.Repository;
using EasyCom.Api.ActionFilters;

namespace EasyCom.Api.Controllers
{
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController
    {
        private const string LocalLoginProvider = "Local";
        IProductProvider productProvider;
    

        public ProductController(IProductProvider providerObject)
        {
            //GetProvider();

            //IUnityContainer container = new UnityContainer();
            //container.RegisterType<ProductProvider>();
            //container.RegisterType<IProductRepository, ProductRepository>();
            //IProductProvider providerObject = container.Resolve<ProductProvider>();
            productProvider = providerObject;
            //return providerObject;
        }

        //public Product GetProduct()
        //{
        //    return productProvider.GetProduct(1);
        //}

       //[Route("ShowProductById/{productId}")]
        public Product GetProductById(int productId)
        {
            return productProvider.GetProduct(productId);
        }

        //public Product GetProductByName([FromUri(Name = "productId")]string name)
        //{
        //    Product p = productProvider.GetProduct(1);
        //    p.ProductName = name;
        //    return p;
        //}

        [ExecutionTimeFilterAttribute]
        [Route("ShowAllProducts")]
        public List<Product> GetAllProducts()
        {
            return productProvider.GetAllProducts();
        }

        //[ExecutionTimeFilterAttribute]
        //[Route("ShowOfferProducts")]
        //public List<Product> GetAllOfferProducts()
        //{
        //    return productProvider.GetAllProductsWithOffer();
        //}

        //private IProductProvider GetProvider()
        //{

        //}


    }
}

