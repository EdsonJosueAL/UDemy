using System;
using System.Runtime.Serialization;

namespace WcfService
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int IDCliente;

        [DataMember]
        public string Nombre;

        [DataMember]
        public DateTime FechaNacimiento;
    }
}
