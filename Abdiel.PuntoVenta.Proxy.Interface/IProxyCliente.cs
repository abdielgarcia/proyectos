using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdiel.PuntoVenta.Proxy.Interface
{
  public  interface IProxyCliente
    {

        List<Common.Models.Interface.ICliente> listarClientes(Common.Models.Interface.ICliente model);

    }
}
