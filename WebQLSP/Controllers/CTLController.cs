using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebQLSP.Models;

namespace WebQLSP.Controllers
{
    public class CTLController : Controller
    {
        // GET: CTL
        public ActionResult Index()
        {
            QuanLySanPhamDataContext context = new QuanLySanPhamDataContext("");
            List<CTL> dsCatalog = context.CTLs.ToList();
            return View(dsCatalog);
        }
    }
}