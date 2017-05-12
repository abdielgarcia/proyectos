﻿using Abdiel.PuntoVenta.Proxy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdiel.PuntoVenta.Proxy
{
    public class ProxyClienteCostaRica : IProxyCliente
    {

        private Service.Interface.ICliente proxy = null;

       public ProxyClienteCostaRica(Service.Interface.ICliente proxy)
        {
            this.proxy = proxy;
        }
        List<Common.Models.Interface.ICliente> IProxyCliente.listarClientes(Common.Models.Interface.ICliente model)
        {

         return   proxy.ListarClientes(model);
           
        }
    }
}
