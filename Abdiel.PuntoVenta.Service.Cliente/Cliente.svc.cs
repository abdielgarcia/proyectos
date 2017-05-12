using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Abdiel.PuntoVenta;
using Abdiel.PuntoVenta.Common;
using Abdiel.PuntoVenta.Service.Interface;
using Abdiel.PuntoVenta.BusinessLogic;

namespace Abdiel.PuntoVenta.Service.Cliente
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Cliente" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Cliente.svc or Cliente.svc.cs at the Solution Explorer and start debugging.
    public class Cliente : ICliente
    {
        BusinessLogic.Interface.ICliente cliente;
        public Cliente(BusinessLogic.Interface.ICliente cliente)
        {
            this.cliente = cliente;
        }
        List<Common.Models.Interface.ICliente> Interface.ICliente.ListarClientes(Common.Models.Interface.ICliente model)
        {
            cliente.ListaClientes(model);
            throw new NotImplementedException();
        }
        
    }
}
