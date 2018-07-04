using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppMVC.Models
{
    public class Usuario
    {
        public int IDUsuario
        {
            get;
            set;
        }

        public string NombreUsuario
        {
            get;
            set;
        }

        public string Cargo
        {
            get;
            set;
        }
    }
}