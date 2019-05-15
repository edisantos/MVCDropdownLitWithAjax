using MVCDropdowlist.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDropdowlist.MVC.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            ViewBag.ProdutoId = new SelectList(db.Produtos, "ProdutoId", "Nome");
            return View();
        }
        public JsonResult MostrarValor(int ProdutoId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<Produtos> ProdutoList = db.Produtos.Where(x => x.ProdutoId == ProdutoId).ToList();
            return Json(ProdutoList, JsonRequestBehavior.AllowGet);
        }



    }
}