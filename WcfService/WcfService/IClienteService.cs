//https://danielggarcia.wordpress.com/2013/12/12/wcf-ii-creacion-de-un-servicio-web-simple/

using System.Collections.Generic;
using System.ServiceModel;

namespace WcfService
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        List<Cliente> ObtenerClientes();

        [OperationContract]
        void InsertarCliente(Cliente cliente);

        [OperationContract]
        void ModificarCliente(Cliente cliente);

        [OperationContract]
        void EliminarCliente(int idCliente);
    }
}
