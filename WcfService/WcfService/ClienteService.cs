using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace WcfService
{
    [ServiceBehavior]
    public class ClienteService : IClienteService
    {
        private static List<Cliente> listaClientes = new List<Cliente>();

        public void EliminarCliente(int idCliente)
        {
            // Recuperamos el cliente cuyo ID coincide con el pasado como parámetro
            Cliente clienteEliminar = listaClientes.Where(cliente => cliente.IDCliente == idCliente).First();

            // Si el registro existe, se elimina
            if (clienteEliminar != null)
            {
                listaClientes.Remove(clienteEliminar);
            }
        }

        public void InsertarCliente(Cliente cliente)
        {
            // Calculamos el ID del siguiente elemento
            if (listaClientes.Count == 0)
                cliente.IDCliente = 1;
            else
                cliente.IDCliente = listaClientes.Max(Cliente => Cliente.IDCliente) + 1;

            // Añadimos el cliente a la lista
            listaClientes.Add(cliente);
        }

        public void ModificarCliente(Cliente cliente)
        {
            // Recuperamos el cliente cuyo ID coincide con el pasado como parámetro
            Cliente clienteModif = listaClientes.Where(Cliente => Cliente.IDCliente == cliente.IDCliente).First();

            // Si el registro existe, se modifica
            if (clienteModif != null)
            {
                clienteModif.Nombre = cliente.Nombre;
                clienteModif.FechaNacimiento = cliente.FechaNacimiento;
            }
        }

        public List<Cliente> ObtenerClientes()
        {
            return (listaClientes);
        }
    }
}
