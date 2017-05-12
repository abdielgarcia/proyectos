using Abdiel.PuntoVenta.Common.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Abdiel.PuntoVenta.Common.Models
{

    /// <summary>
    /// Clase modelo de un Cliente
    /// </summary> /// <summary>
    /// Clase modelo de cliente
    /// </summary>
    [Serializable]
    [DataContract]
    public class Cliente : ICliente
    {

        /// <summary>
        /// Represanta el Id de un cliente
        /// </summary>
        [DataMember]
        public int IdCliente { get; set; }

        /// <summary>
        /// Reprsenta el Nombre del cliente
        /// </summary>
        [DataMember]
        public string Nombre { get; set; }


        /// <summary>
        /// Representa el primer apellido del cliente
        /// </summary>
        [DataMember]
        public string PrimerApellido { get; set; }


        /// <summary>
        /// Representa el segundo Apellido del cliente
        /// </summary>
        [DataMember]
        public string SegundoApellido { get; set; }


    }
}
