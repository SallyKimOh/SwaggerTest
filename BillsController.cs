using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
//using Interop.QBXMLRP2;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwaggerTest.Data;
using SwaggerTest.Models;
using SwaggerTest.Models.Bill;
using SwaggerTest.Models.BillPayment;
using SwaggerTest.Models.Common;

namespace SwaggerTest.Controllers
{
    [Route("/bill")]
    public class BillsController : Controller
    {

        [Route("/bills")]
        public JsonResult Index()
        {

            var initLink = new TopLinks<CommLinksItem, BillEmbed<List<BillInfo>>>()
            {
                _links = new CommLinksItem()
                {
                    Self = new LinksItemSub { Href = Request.Path.ToString() },
                    Next = new LinksItemSub { Href = Request.Path.ToString() + "/2" },
                },
                _embedded = new BillEmbed<List<BillInfo>>
                {
                    Bills = ListBills()
                }
            };

            return Json(initLink);

        }

        [Route("BillList")]
        public List<BillInfo> ListBills()
        {

//            string response = new CommonApiController().ExtractXml(new ConstantValue().BILLQUERY);

            List<BillInfo> list = new List<BillInfo>();

            BillInfo info;
/*
            XmlReader reader = XmlReader.Create(new StringReader(response));
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    info = new BillInfo();
                    var vendorId = "";
                    if (reader.ReadToFollowing("TxnID"))
                    {
                        info.ID = reader.ReadElementContentAsObject().ToString();
                    }
                    if (reader.ReadToFollowing("VendorRef"))
                    {

                        if (reader.ReadToFollowing("ListID"))
                        {
                            vendorId = reader.ReadElementContentAsObject().ToString();
                        }
                    }

                    if (reader.ReadToFollowing("APAccountRef"))
                    {
                        if (reader.ReadToFollowing("ListID"))
                        {
                            info.AccountID = reader.ReadElementContentAsObject().ToString();
                        }
                    }
                    info._links = new LinksItem()
                    {
                        Self = new LinksItemSub { Href = new ConstantValue().BILLINITLINK + "/" + info.ID }
                    };

                    list.Add(info);
                    
                }
            }
            */
            return list;
        }




        [Route("vendorBillList")]
        public List<BillInfo> VendorBillXml(string id)
        {

 //           id = "8000000F-1504184790";

//            string response = new CommonApiController().ExtractXml(new ConstantValue().BILLQUERY);


            List<BillInfo> list = new List<BillInfo>();

            BillInfo info;
            /*
            XmlReader reader = XmlReader.Create(new StringReader(response));
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    info = new BillInfo();
                    var vendorId = "";
                    if (reader.ReadToFollowing("TxnID"))
                    {
                        info.ID = reader.ReadElementContentAsObject().ToString();
                    }
                    if (reader.ReadToFollowing("VendorRef"))
                    {

                        if (reader.ReadToFollowing("ListID"))
                        {
                            vendorId = reader.ReadElementContentAsObject().ToString();
                        }
                    }

                    if (reader.ReadToFollowing("APAccountRef"))
                    {
                        if (reader.ReadToFollowing("ListID"))
                        {
                            info.AccountID = reader.ReadElementContentAsObject().ToString();
                        }
                    }
                    info._links = new LinksItem()
                    {
                        Self = new LinksItemSub { Href = new ConstantValue().BILLINITLINK + "/" + info.ID }
                    };

                    if (vendorId == id)
                    {
                        list.Add(info);

                    }

                }
            }
            */
            return list;
        }

        [Route("/accList")]
        public List<BillInfo> AccountBillXml(string id)
        {

 //           id = "80000008-1504182813";

 //           string response = new CommonApiController().ExtractXml(new ConstantValue().BILLQUERY);


            List<BillInfo> list = new List<BillInfo>();

            BillInfo info;
            /*
            XmlReader reader = XmlReader.Create(new StringReader(response));
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    info = new BillInfo();
                    if (reader.ReadToFollowing("TxnID"))
                    {
                        info.ID = reader.ReadElementContentAsObject().ToString();
                    }

                    if (reader.ReadToFollowing("APAccountRef"))
                    {
                        if (reader.ReadToFollowing("ListID"))
                        {
                            info.AccountID = reader.ReadElementContentAsObject().ToString();
                        }
                    }
                    info._links = new LinksItem()
                    {
                        Self = new LinksItemSub { Href = new ConstantValue().BILLINITLINK + "/" + info.ID }
                    };

                    if (info.AccountID == id)
                    {
                        list.Add(info);

                    }

                }
            }
            */
            return list;
        }



        [Route("/bills/{id}")]
        public JsonResult BillDetail(string id)
        {

            string response = null;

 //           response = new CommonApiController().ExtractXml(new ConstantValue().BILLQUERY, id,"B");       //extract xml

            BillDetailInfo info = new BillDetailInfo();
            /*
            XmlReader reader = XmlReader.Create(new StringReader(response));
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    if (reader.ReadToFollowing("TxnID"))
                    {
                        info.ID = reader.ReadElementContentAsObject().ToString();
                    }
                    if (reader.ReadToFollowing("TimeModified"))
                    {
                        info.TimeMod = reader.ReadElementContentAsObject().ToString();
                    }
                    if (reader.ReadToFollowing("VendorRef"))
                    {
                        if (reader.ReadToFollowing("ListID"))
                        {
                            info.VendorID = reader.ReadElementContentAsObject().ToString();
                        }
                        if (reader.ReadToFollowing("FullName"))
                        {
                            info.VenderName = reader.ReadElementContentAsObject().ToString();
                        }
                    }
                    if (reader.ReadToFollowing("APAccountRef"))
                    {
                        if (reader.ReadToFollowing("ListID"))
                        {
                            info.AccountID = reader.ReadElementContentAsObject().ToString();
                        }
                        if (reader.ReadToFollowing("FullName"))
                        {
                            info.AccountName = reader.ReadElementContentAsObject().ToString();
                        }
                    }
                    if (reader.ReadToFollowing("AmountDue"))
                    {
                        info.AmountDue = reader.ReadElementContentAsDouble();
                    }
                    if (reader.ReadToFollowing("OpenAmount"))
                    {
                        info.OpenAmount = reader.ReadElementContentAsDouble();
                    }

                    BillPaymentInfo billpayInfo = getBillPaymentID(info.TimeMod,info.VendorID,info.AccountID);

                    info._links = new BillLinksItem()
                    {
                        Self = new LinksItemSub { Href = new ConstantValue().BILLINITLINK + "/" + info.ID },
                        Vendor = new LinksItemSub { Href = new ConstantValue().VENDERINITLINK + "/" + info.VendorID },
                        BillPayment = new LinksItemSub { Href = new ConstantValue().BILLPAYMENTINITLINK + "/" + billpayInfo.PaymentType + "/" + billpayInfo.ID }
//                        BillPayment = new LinksItemSub { Href = new ConstantValue().BILLINITLINK + "/" + info.TimeMod }
                    };

                }
            }
*/
            return Json(info);

        }



        public BillPaymentInfo getBillPaymentID(string time, string vendorID, string accoundID)
        {

//            string response = new CommonApiController().ExtractXml(new ConstantValue().BILLPAYCHECKQUERY);
//            string response1 = new CommonApiController().ExtractXml(new ConstantValue().BILLPAYCREDITCARDQUERY);

            string id = "";
            string crTime = "";
            string strVendorID = "";
            string strAccoundID = "";

            BillPaymentInfo info = new BillPaymentInfo();
            /*
            XmlReader reader = XmlReader.Create(new StringReader(response));
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    if (reader.ReadToFollowing("TxnID"))
                    {
                        id = reader.ReadElementContentAsObject().ToString();
                    }

                    if (reader.ReadToFollowing("TimeCreated"))
                    {
                        crTime = reader.ReadElementContentAsObject().ToString();
                    }

                    if (reader.ReadToFollowing("PayeeEntityRef"))
                    {
                        if (reader.ReadToFollowing("ListID"))
                        {
                            strVendorID = reader.ReadElementContentAsObject().ToString();
                        }
                    }
                    if (reader.ReadToFollowing("APAccountRef"))
                    {
                        if (reader.ReadToFollowing("ListID"))
                        {
                            strAccoundID = reader.ReadElementContentAsObject().ToString();
                        }
                    }

                    if ((crTime == time) && (strVendorID == vendorID) && (strAccoundID == accoundID) && (id != null))
                    {
                        info.ID = id;
                        info.PaymentType = new ConstantValue().BILLPAYMENTCHECKTYPE;
                        return info;
                    }

                }
            }

            reader = XmlReader.Create(new StringReader(response1));
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    if (reader.ReadToFollowing("TxnID"))
                    {
                        id = reader.ReadElementContentAsObject().ToString();
                    }

                    if (reader.ReadToFollowing("TimeCreated"))
                    {
                        crTime = reader.ReadElementContentAsObject().ToString();
                    }

                    if (reader.ReadToFollowing("PayeeEntityRef"))
                    {
                        if (reader.ReadToFollowing("ListID"))
                        {
                            strVendorID = reader.ReadElementContentAsObject().ToString();
                        }
                    }
                    if (reader.ReadToFollowing("APAccountRef"))
                    {
                        if (reader.ReadToFollowing("ListID"))
                        {
                            strAccoundID = reader.ReadElementContentAsObject().ToString();
                        }
                    }

                    if ((crTime == time) && (strVendorID == vendorID) && (strAccoundID == accoundID) && (id != null))
                    {
                        info.ID = id;
                        info.PaymentType = new ConstantValue().BILLPAYMENTCREDITTYPE;
                        return info;
                    }
                }
            }
*/
            return info;
        }



        public string getBillPaymentID2(string time)
        {
/*            string data1 = new CommonApiController().ExtractXml(new ConstantValue().BILLPAYCHECKQUERY);

//            string[] resp = { new CommonApiController().ExtractXml(new ConstantValue().BILLPAYCHECKQUERY), new CommonApiController().ExtractXml(new ConstantValue().BILLPAYCREDITCARDQUERY) };
 //           string[] resp = { data1};
            string[] resp = new string[1];
            resp[0] = data1;
*/
            string paymentID = "";
            /*
            string crTime = "";
            for (int i = 0; i < resp.Length; i++)
            {
                XmlReader reader = XmlReader.Create(new StringReader(resp[i]));
                while (reader.Read())
                {
                    string id = "";
                    if (reader.IsStartElement())
                    {
                        if (reader.ReadToFollowing("TxnID"))
                        {
                            id = reader.ReadElementContentAsObject().ToString();
                        }

                        if (reader.ReadToFollowing("TimeCreted"))
                        {
                            crTime = reader.ReadElementContentAsObject().ToString();
                        }

                        //if (crTime.Equals(time))
                        //{
                        //    paymentID = "AAAA";
                        //} else
                        //{
                        //    paymentID = "BBB";
                        //}


                    }

                    if (crTime.Equals(time))
                    {
                        paymentID = "AAAA";
                        break;
                    }
                    else if (crTime.Trim() == time.Trim())
                    {
                        paymentID = "BBB";
                    } else
                    {

                        paymentID = crTime+"/"+time;
                    }


                }
            }
*/
            return paymentID;
        }


    }
}