using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwaggerTest.Models;

namespace SwaggerTest.Helpers
{

    public static class InitialHelper
    {

        public static Company GetCompanyInfo()
        {
            var companyInfos =
                new Company(
                    new List<FindTypes>()
                        {
                            new FindTypes()
                                {
                                    FindTypeNm = "Vendor",
                                    Description = "Vendor List",
                                    Href = "/vendor/1",
                                    Links =
                                        {
                                            new Link() { Rel = "collection", Href = "/QBxmlApi/VendorXml" },
                                            new Link() { Rel = "template", Href = "/vendor/{vendorId}" },
                                        }
                                },
                            new FindTypes()
                                {
                                    FindTypeNm = "Customer",
                                    Description = "Customer List",
                                    Href = "/vendor/1",
                                    Links =
                                        {
                                            new Link() { Rel = "collection", Href = "/QBxmlApi/MakeXmlToJson?type=customer&dataType=R" },
                                            new Link() { Rel = "template", Href = "/vendor/{vendorId}" },
                                        }
                                },
                            new FindTypes()
                                {
                                    FindTypeNm = "Employee",
                                    Description = "Employee List",
                                    Href = "/Employee/1",
                                    Links =
                                        {
                                            new Link() { Rel = "collection", Href = "/QBxmlApi/MakeXmlToJson?type=employee&dataType=R" },
                                            new Link() { Rel = "template", Href = "/vendor/{vendorId}" },
                                        }
                                },
                            new FindTypes()
                                {
                                    FindTypeNm = "Service",
                                    Description = "Service List",
                                    Href = "/Service/1",
                                    Links =
                                        {
                                            new Link() { Rel = "collection", Href = "/QBxmlApi/MakeXmlToJson?type=service&dataType=R" },
                                            new Link() { Rel = "template", Href = "/vendor/{vendorId}" },
                                        }
                                },
                        });




            return companyInfos;
        }

 
        public static FindTypes GetFindType(string type)
        {
            var findType = GetCompanyInfo().SingleOrDefault(p => p.FindTypeNm == type);
            return findType;
        }
    }
}
