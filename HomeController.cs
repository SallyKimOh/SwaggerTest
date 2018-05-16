using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SwaggerTest.Models;
using SwaggerTest.Models.Vendor;
using SwaggerTest.Helpers;
using SwaggerTest.Extensions;
using SwaggerTest.Models.Home;
using SwaggerTest.Data;

namespace SwaggerTest.Controllers
{
    public class HomeController : Controller
    {


		public JsonResult Index() {

            var list = new HomeLinks<HomeLinksItem>()
            {
                _links = new HomeLinksItem()
                {
                    Self = new LinksItemSub { Href = Request.Path.ToString() },
                    Customers = new LinksItemSub { Href = new ConstantValue().CUSTOMERINITLINK },
                    Employees = new LinksItemSub { Href = new ConstantValue().EMPLOYEEINITLINK },
                    Vendors = new LinksItemSub { Href = new ConstantValue().VENDERINITLINK },
                    Accounts = new LinksItemSub {  Href = new ConstantValue().ACCOUNTINITLINK },
                    Bills = new LinksItemSub {  Href = new ConstantValue().BILLINITLINK },
                    BillPayments = new LinksItemSub { Href = new ConstantValue().BILLPAYMENTINITLINK},
                    PayRolls = new LinksItemSub { Href = new ConstantValue().PAYROLLINITLINK },
                    Transactions = new LinksItemSub { Href = new ConstantValue().TRANSACTIONINITLINK }


                },
                Company = new ConstantValue().COMPANYNAME,
                QbFileName = new ConstantValue().QBFILENAME
            };


            return Json(list);
        }
        

        [Route("List")]
        public JsonResult List()
        {

            var products = ProductHelper.GetProducts();

            products.Href = Request.Path.ToString();
            products.AddLink(new Link() { Rel = "next", Href = "/products?p=2" });
            products.AddLink(new Link() { Rel = "template", Href = "/product/{productId}" });

            return Json(products);
     
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }




    internal class Test
    {
        public string Link { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

    }


}
