using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebQLSP.Models;

namespace WebQLSP.Controllers
{
    public class PDController : Controller
    {
        // GET: PD
        public ActionResult Index()
        {
            QuanLySanPhamDataContext context = new QuanLySanPhamDataContext("");
            List<PD> dsProduct = context.PDs.ToList();
            return View(dsProduct);
        }
    }
}