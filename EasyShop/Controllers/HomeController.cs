using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using EasyCom.Api.Types;
using Newtonsoft.Json;

namespace EasyShop.Controllers
{
    public class HomeController : Controller
    {
        HttpClient client;
        //The URL of the WEB API Service
        string url = "http://localhost/EasyComApi/api/Products";
        //The HttpClient Class, this will be used for performing 
        //HTTP Operations, GET, POST, PUT, DELETE
        //Set the base address and the Header Formatter
        public HomeController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        //public ActionResult Index()
        //{
        //    HttpResponseMessage responseMessage = await client.GetAsync(url);
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        var responseData = responseMessage.Content.ReadAsStringAsync().Result;

        //        var Employees = JsonConvert.DeserializeObject<List<EmployeeInfo>>(responseData);

        //        return View(Employees);
        //    }
        //    //HttpResponseMessage response = client.GetAsync("api/product/GetAll").Result;
        //    //if (response.IsSuccessStatusCode)
        //    //{
        //    //   // products = response.Content.ReadAsAsync<IEnumerable<ProductViewModels>>().Result;
        //    //    //Console.WriteLine("{0}\t${1}\t{2}", product.Name, product.Price, product.Category);
        //    //}
        //    // var webApi = new ProductsController();
        //    // ViewBag.Message = webApi.Get(1); // Change ViewBag.Message to something for your controller
        //    //return View();
        //    return View();
        //}

        // GET: EmployeeInfo
        public async Task<ActionResult> Index()
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                var products = JsonConvert.DeserializeObject<List<Product>>(responseData);

                return View(products);
            }
            return View("Error");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}