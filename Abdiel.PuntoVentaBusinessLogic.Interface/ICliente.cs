using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Abdiel.PuntoVenta.BusinessLogic.Interface
{
  public  interface ICliente
    {
        List<Common.Models.Interface.ICliente> ListaClientes(Common.Models.Interface.ICliente model);
        

    }
}
