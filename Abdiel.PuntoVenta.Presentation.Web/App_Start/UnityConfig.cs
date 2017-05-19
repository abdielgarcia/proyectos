using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Abdiel.PuntoVenta.Proxy.Interface;
using Abdiel.PuntoVenta.Proxy;
using Abdiel.PuntoVenta.Common;
using Abdiel.PuntoVenta.BusinessLogic;
using Abdiel.PuntoVenta.Common.Models;
namespace Abdiel.PuntoVenta.Presentation.Web.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below. Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.

            IUnityContainer container2 = new UnityContainer();
         
            container2.LoadConfiguration("myconfig");

            // TODO: Register your types here
       
            //container.RegisterType<IProxyCliente, ProxyClienteNicaragua>();
            //container.RegisterType<Common.Models.Interface.ICliente, Common.Models.Cliente>();
            //container.RegisterType<BusinessLogic.Interface.ICliente, BusinessLogic.Cliente>();
            //container.RegisterType<Service.Interface.ICliente, Service.Cliente.Cliente>();
            
        }
    }
}
