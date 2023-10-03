using Aplicacao_web_ds_eve.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplicacao_web_ds_eve.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var cliente = new Cliente();
            return View(cliente);
        }
        [HttpPost]
        public ActionResult Index(Cliente cliente)
        {
            if(ModelState.IsValid)
            {
                return View("Resultado", cliente);
            }
            return View(cliente);
        }
        public ActionResult Resultado(Cliente cliente)
        {
            return View(cliente);
        }
    }
}