using Abdiel.PuntoVenta.BusinessLogic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abdiel.PuntoVenta.Common;
namespace Abdiel.PuntoVenta.BusinessLogic
{
    public class Cliente : ICliente
    {
        public List<Common.Models.Interface.ICliente> ListaClientes(Common.Models.Interface.ICliente model)
        {
            List<Common.Models.Interface.ICliente> listaClientes = new List<Common.Models.Interface.ICliente>();
            listaClientes.Add(model);
            return listaClientes;
        }
    }
}
