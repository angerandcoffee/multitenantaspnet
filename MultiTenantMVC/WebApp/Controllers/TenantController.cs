using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class TenantController : Controller
    {
        // GET: Tenant
        public ActionResult Index()
        {
            var tenants = new List<Tenant>
            {
                new Tenant
                {
                    Name = "SVCC",
                    DomainName="www.siliconvalley-codecamp.com",
                    Id = 1,
                    Default = true
                },
                new Tenant
                {
                    Name = "ANGU",
                    DomainName="angularu.com",
                    Id = 2,
                    Default = false
                },
                new Tenant
                {
                    Name = "CSSC",
                    DomainName="codestarssummit.com",
                    Id = 3,
                    Default = false
                }
            };
            return View(tenants);
        }
    }
}