using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Interop.QBXMLRP2;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwaggerTest.Data;

namespace SwaggerTest.Controllers
{
    public class CommonApiController : Controller
    {

 /*       public string ExtractXml(string type)
        {
            RequestProcessor2 rp = null;

            string ticket = null;
            string response = null;

            try
            {
                rp = new RequestProcessor2();
                rp.OpenConnection(new ConstantValue().appID, new ConstantValue().appName);
                ticket = rp.BeginSession(new ConstantValue().QBFILEPATH + new ConstantValue().QBFILENAME, new ConstantValue().QBFILEMODE);

                response = rp.ProcessRequest(ticket, new Utils().MakeXmlInitElements(type).OuterXml);
            }

            catch (System.Runtime.InteropServices.COMException ex)
            {
                return ex.Message;
            }
            finally
            {
                if (ticket != null)
                {
                    rp.EndSession(ticket);
                }

                if (rp != null)
                {
                    rp.CloseConnection();
                }
            };

            return response;

        }

        public string ExtractXml(string type,string id)
        {
            RequestProcessor2 rp = null;

            string ticket = null;
            string response = null;

            try
            {
                rp = new RequestProcessor2();
                rp.OpenConnection(new ConstantValue().appID, new ConstantValue().appName);
                ticket = rp.BeginSession(new ConstantValue().QBFILEPATH + new ConstantValue().QBFILENAME, new ConstantValue().QBFILEMODE);

                response = rp.ProcessRequest(ticket, new Utils().MakeXmlInitElements(type,id).OuterXml);
            }

            catch (System.Runtime.InteropServices.COMException ex)
            {
                return ex.Message;
            }
            finally
            {
                if (ticket != null)
                {
                    rp.EndSession(ticket);
                }

                if (rp != null)
                {
                    rp.CloseConnection();
                }
            };

            return response;

        }

        public string ExtractXml(string datatype, string id, string type)
        {
            RequestProcessor2 rp = null;

            string ticket = null;
            string response = null;

            try
            {
                rp = new RequestProcessor2();
                rp.OpenConnection(new ConstantValue().appID, new ConstantValue().appName);
                ticket = rp.BeginSession(new ConstantValue().QBFILEPATH + new ConstantValue().QBFILENAME, new ConstantValue().QBFILEMODE);

                response = rp.ProcessRequest(ticket, new Utils().MakeXmlInitElements(datatype, id,type).OuterXml);
            }

            catch (System.Runtime.InteropServices.COMException ex)
            {
                return ex.Message;
            }
            finally
            {
                if (ticket != null)
                {
                    rp.EndSession(ticket);
                }

                if (rp != null)
                {
                    rp.CloseConnection();
                }
            };

            return response;

        }
*/

    }
}