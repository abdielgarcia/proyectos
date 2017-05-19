using Abdiel.PuntoVenta.Proxy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Abdiel.PuntoVenta.Presentation.Web.Controllers
{
    public class HomeController : Controller
    {
       

        private IProxyCliente cliente;
        public HomeController(IProxyCliente cliente)
        {
            this.cliente = cliente;
           
        }
        // GET: Home
        public ActionResult Index()
        {
            Common.Models.Cliente model = new Common.Models.Cliente();
            return View(cliente.listarClientes(model));
        }
        //public ActionResult Index(Common.Models.Interface.ICliente model)
        //{
        //    cliente.listarClientes(model);
        //    return View();
        //}
    }
}