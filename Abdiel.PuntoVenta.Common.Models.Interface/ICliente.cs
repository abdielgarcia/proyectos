using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdiel.PuntoVenta.Common.Models.Interface
{

    /// <summary>
    /// Interfaz del modelo Cliente
    /// </summary>
   public  interface ICliente
    {
        /// <summary>
        /// Identificador del cliente
        /// </summary>
        int IdCliente { get; set; }
        /// <summary>
        /// Nombre del cliente
        /// </summary>

        string Nombre { get; set; }
        /// <summary>
        /// Primer apellido del cliente
        /// </summary>

        string PrimerApellido { get; set; }
        /// <summary>
        /// Segundo apellido del cliente
        /// </summary>

        string SegundoApellido { get; set; }
       
      

    }
}
