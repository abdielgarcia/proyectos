using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Abdiel.PuntoVenta.Service.Interface
{

    /// <summary>
    /// Establece los contratos del microservicio de Clientes. 
    /// </summary>
    /// 
   // [ServiceKnownType("GetKnownDevolucionTypes", typeof(KnownTypeHelper))]
    [ServiceContract]
    public interface ICliente
    {
        /// <summary>
        /// Metodo que va a exponer los datos de los clientes para que sean consumidos desde un cliente,
        /// El metodo recibe un pbjeto de tipo Icliente Common.Models.Interface.ICliente que puede ir vacio
        /// </summary>
        /// <returns> List<Common.Models.Interface.ICliente> </returns>
        [OperationContract]
        List<Common.Models.Interface.ICliente>  ListarClientes (Common.Models.Interface.ICliente model);
    }
}
