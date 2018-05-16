using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
//using Interop.QBXMLRP2;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerTest.Data
{
    public class Utils
    {
/*		
        RequestProcessor2 rp = null;

        string ticket = null;
        string response = null;

        public static int RandomNum()
        {
            Random random = new Random();
            return random.Next(new ConstantValue().RandomMin, new ConstantValue().RandomMax);
        }
        

        public XmlDocument MakeXmlInitElements(String dataType)
        {
            XmlDocument doc = new XmlDocument();
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", null, null));
            doc.AppendChild(doc.CreateProcessingInstruction("qbxml", "version=\"13.0\""));
            XmlElement firstElement = doc.CreateElement("QBXML");
            doc.AppendChild(firstElement);
            XmlElement inner = doc.CreateElement("QBXMLMsgsRq");
            firstElement.AppendChild(inner);
            inner.SetAttribute("onError", "stopOnError");

            //            XmlElement inner1 = doc.CreateElement("CustomerQueryRq");
            XmlElement inner1 = doc.CreateElement(dataType);
            inner.AppendChild(inner1);
            inner1.SetAttribute("requestID", "1");

            return doc;

        }

        public XmlDocument MakeXmlInitElements(String dataType, String id)
        {
            XmlDocument doc = new XmlDocument();
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", null, null));
            doc.AppendChild(doc.CreateProcessingInstruction("qbxml", "version=\"13.0\""));
            XmlElement firstElement = doc.CreateElement("QBXML");
            doc.AppendChild(firstElement);
            XmlElement inner = doc.CreateElement("QBXMLMsgsRq");
            firstElement.AppendChild(inner);
            inner.SetAttribute("onError", "stopOnError");



            XmlElement secondEle = doc.CreateElement(dataType);
            inner.AppendChild(secondEle);
            secondEle.SetAttribute("requestID", "1");

            if (id != null)
            {
                XmlElement thirdEle = doc.CreateElement("ListID");
                secondEle.AppendChild(thirdEle);
                thirdEle.InnerText = id;
            }

            return doc;

        }


        public XmlDocument MakeXmlInitElements(string dataType, string id,string type)
        {
            XmlDocument doc = new XmlDocument();
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", null, null));
            doc.AppendChild(doc.CreateProcessingInstruction("qbxml", "version=\"13.0\""));
            XmlElement firstElement = doc.CreateElement("QBXML");
            doc.AppendChild(firstElement);
            XmlElement inner = doc.CreateElement("QBXMLMsgsRq");
            firstElement.AppendChild(inner);
            inner.SetAttribute("onError", "stopOnError");



            XmlElement secondEle = doc.CreateElement(dataType);
            inner.AppendChild(secondEle);
            secondEle.SetAttribute("requestID", "1");

            if ((id != null) && (type == "B"))      //Type :B - bill
            {
                XmlElement thirdEle = doc.CreateElement("TxnID");
                secondEle.AppendChild(thirdEle);
                thirdEle.InnerText = id;
            } else
            {
                XmlElement thirdEle = doc.CreateElement("ListID");
                secondEle.AppendChild(thirdEle);
                thirdEle.InnerText = id;
            }

            return doc;

        }

        public string DoMakingQuery(string dataType)
        {

            rp = new RequestProcessor2();

            XmlDocument doc = new XmlDocument();
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", null, null));
            doc.AppendChild(doc.CreateProcessingInstruction("qbxml", "version=\"13.0\""));

            XmlElement outer = doc.CreateElement("QBXML");
            doc.AppendChild(outer);

            XmlElement inner = doc.CreateElement("QBXMLMsgsRq");
            outer.AppendChild(inner);
            inner.SetAttribute("onError", "stopOnError");

            BuildQueryRq(doc, inner, dataType);

            rp.OpenConnection(new ConstantValue().appID, new ConstantValue().appName);

            ticket = rp.BeginSession(new ConstantValue().QBFILEPATH + new ConstantValue().QBFILENAME, new ConstantValue().QBFILEMODE);

            response = rp.ProcessRequest(ticket, doc.OuterXml);

            return response;

        }

        public string DoMakingQuery(string dataType,string tagName,string id)
        {

            rp = new RequestProcessor2();

            XmlDocument doc = new XmlDocument();
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", null, null));
            doc.AppendChild(doc.CreateProcessingInstruction("qbxml", "version=\"13.0\""));

            XmlElement outer = doc.CreateElement("QBXML");
            doc.AppendChild(outer);

            XmlElement inner = doc.CreateElement("QBXMLMsgsRq");
            outer.AppendChild(inner);
            inner.SetAttribute("onError", "stopOnError");

            BuildQueryDetailRq(doc, inner, dataType, tagName, id);

            rp.OpenConnection(new ConstantValue().appID, new ConstantValue().appName);

            ticket = rp.BeginSession(new ConstantValue().QBFILEPATH + new ConstantValue().QBFILENAME, new ConstantValue().QBFILEMODE);

            response = rp.ProcessRequest(ticket, doc.OuterXml);

            return response;

        }


        public string DoMakingQuery(string dataType, string date)
        {

            rp = new RequestProcessor2();

            XmlDocument doc = new XmlDocument();
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", null, null));
            doc.AppendChild(doc.CreateProcessingInstruction("qbxml", "version=\"13.0\""));

            XmlElement outer = doc.CreateElement("QBXML");
            doc.AppendChild(outer);

            XmlElement inner = doc.CreateElement("QBXMLMsgsRq");
            outer.AppendChild(inner);
            inner.SetAttribute("onError", "stopOnError");

            BuildQueryForTransactionRq(doc, inner, dataType, date);

            rp.OpenConnection(new ConstantValue().appID, new ConstantValue().appName);

            ticket = rp.BeginSession(new ConstantValue().QBFILEPATH + new ConstantValue().QBFILENAME, new ConstantValue().QBFILEMODE);

            response = rp.ProcessRequest(ticket, doc.OuterXml);

            return response;

        }




        public string Report(string dataType, string tagName, string tagVal)
        {

            //RequestProcessor2 rp = null;

            //string ticket = null;
            //string response = null;

            rp = new RequestProcessor2();


            XmlDocument doc = new XmlDocument();
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", null, null));
            doc.AppendChild(doc.CreateProcessingInstruction("qbxml", "version=\"13.0\""));

            XmlElement outer = doc.CreateElement("QBXML");
            doc.AppendChild(outer);

            XmlElement inner = doc.CreateElement("QBXMLMsgsRq");
            outer.AppendChild(inner);
            inner.SetAttribute("onError", "stopOnError");

            BuildQueryRq(doc, inner, dataType, tagName, tagVal);

            rp.OpenConnection(new ConstantValue().appID, new ConstantValue().appName);

            ticket = rp.BeginSession(new ConstantValue().QBFILEPATH + new ConstantValue().QBFILENAME, new ConstantValue().QBFILEMODE);

            response = rp.ProcessRequest(ticket, doc.OuterXml);

            return response;

        }



        private void BuildQueryRq(XmlDocument doc, XmlElement parent, string dataType, string tagName, string tagVal)
        {
            //            dataType = "PayrollSummaryReportQueryRq";
            //            tagName = "PayrollSummaryReportType";
            //            tagVal = "EmployeeEarningsSummary";
            //Create PayrollSummaryReportQueryRq aggregate and fill in field values for it
            XmlElement ReportQueryRq = doc.CreateElement(dataType);
            parent.AppendChild(ReportQueryRq);
            //Set field value for PayrollSummaryReportType <!-- required -->
            ReportQueryRq.AppendChild(MakeXmlEle(doc, tagName, tagVal));
            //Set field value for DisplayReport <!-- optional -->
            //            ReportQueryRq.AppendChild(MakeSimpleElem(doc, "DisplayReport", "1"));
            //Begin OR
        }


        public XmlElement MakeXmlEle(XmlDocument doc, string tagName, string tagVal)
        {

            XmlElement secondEle = doc.CreateElement(tagName);
            secondEle.InnerText = tagVal;

            return secondEle;

        }

        private void BuildQueryRq(XmlDocument doc, XmlElement parent, string dataType)
        {
            XmlElement buildQueryRq = doc.CreateElement(dataType);
            parent.AppendChild(buildQueryRq);

//            buildQueryRq.AppendChild(MakeXmlEle(doc, "TxnID", "79-1505493401"));


        }


        private void BuildQueryRq(XmlDocument doc, XmlElement parent, string dataType, string secondEle)
        {
            XmlElement buildQueryRq = doc.CreateElement(dataType);
            parent.AppendChild(buildQueryRq);
            XmlElement PayeeEntityRef = doc.CreateElement(secondEle);
            buildQueryRq.AppendChild(PayeeEntityRef);

        }

        // tagVal must be unique
        private void BuildQueryDetailRq(XmlDocument doc, XmlElement parent, string dataType, string tagName, string tagVal)
        {
            XmlElement buildQueryRq = doc.CreateElement(dataType);
            parent.AppendChild(buildQueryRq);

            buildQueryRq.AppendChild(MakeXmlEle(doc, tagName, tagVal));


        }


        private void BuildQueryForTransactionRq(XmlDocument doc, XmlElement parent, string dataType, string date)
        {
            XmlElement buildQueryRq = doc.CreateElement(dataType);
            parent.AppendChild(buildQueryRq);
            XmlElement TransactionDateRangeFilter = doc.CreateElement("TransactionDateRangeFilter");
            buildQueryRq.AppendChild(TransactionDateRangeFilter);
            TransactionDateRangeFilter.AppendChild(MakeXmlEle(doc, "FromTxnDate", date));
            TransactionDateRangeFilter.AppendChild(MakeXmlEle(doc, "ToTxnDate", date));


        }
*/


    }
}
