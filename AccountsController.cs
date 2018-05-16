using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwaggerTest.Data;
using SwaggerTest.Models;
using SwaggerTest.Models.Account;
using SwaggerTest.Models.Bill;
using SwaggerTest.Models.Common;

namespace SwaggerTest.Controllers
{
    [Route("/accounts")]
    public class AccountsController : Controller
    {

        public JsonResult Index()
        {


            var initLink = new TopLinks<CommLinksItem, AccountEmbedInfo<List<AccountInfo<LinksItem>>>>()
            {
                _links = new CommLinksItem()
                {
                    Self = new LinksItemSub { Href = Request.Path.ToString() },
                    Next = new LinksItemSub { Href = Request.Path.ToString() + "/2" },
                },
                _embedded = new AccountEmbedInfo<List<AccountInfo<LinksItem>>>
                {
                    Accounts = ListAccounts()
                }
            };

            return Json(initLink);

        }


        [Route("/accounts/list")]
        public List<AccountInfo<LinksItem>> ListAccounts()
        {
            string response = null;

//            response = new CommonApiController().ExtractXml(new ConstantValue().ACCOUNTQUERY, "");       //extract xml

            List<AccountInfo<LinksItem>> list = new List<AccountInfo<LinksItem>>();
/*
            AccountInfo<LinksItem> info = new AccountInfo<LinksItem>();

            XmlReader reader = XmlReader.Create(new StringReader(response));
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    if (reader.ReadToFollowing("ListID"))
                    {
                        info = new AccountInfo<LinksItem>() { ID = reader.ReadElementContentAsObject().ToString() };
                    }
                    if (reader.ReadToFollowing("Name"))
                    {
                        info.Name = reader.ReadElementContentAsObject().ToString();
                    }

                    info._links = new LinksItem()
                    {
                        Self = new LinksItemSub { Href = new ConstantValue().ACCOUNTINITLINK + "/" + info.ID }
                    };

                    list.Add(info);

                }
            }
*/
            return list;
        }


        [Route("/accounts/{id}")]
        public JsonResult AccountDetail(string id)
        {

            string response = null;

//            response = new CommonApiController().ExtractXml(new ConstantValue().ACCOUNTQUERY, id);       //extract xml

            AccountDetailInfo<LinksItem> info = new AccountDetailInfo<LinksItem>();

            using (XmlReader reader = XmlReader.Create(new StringReader(response)))
            {
                if (reader.ReadToFollowing("ListID"))
                {
                    info.ID = reader.ReadElementContentAsString();
                }
                if (reader.ReadToFollowing("Name"))
                {
                    info.Name = reader.ReadElementContentAsString();
                }

                if (reader.ReadToFollowing("AccountType"))
                {
                    info.AccountType = reader.ReadElementContentAsString();
                }

                if (reader.ReadToFollowing("BankNumber"))
                {
                    info.BankNumber = reader.ReadElementContentAsString();
                }

                if (reader.ReadToFollowing("Balance"))
                {
                    info.Balance = reader.ReadElementContentAsDouble();
                }

                info._links = new LinksItem()
                {
                    Self = new LinksItemSub { Href = Request.Path.ToString() }
                };

            }

            var initLink = new AccountDetailInfo<BillEmbed<List<BillInfo>>>()
            {
                ID = info.ID,
                Name = info.Name,
                AccountType = info.AccountType,
                BankNumber = info.BankNumber,
                Balance = info.Balance,
                _links = info._links,
                _embedded = new BillEmbed<List<BillInfo>>()
                {
                    Bills = new BillsController().AccountBillXml(info.ID)
                }

            };


            return Json(initLink);

        }







    }
}