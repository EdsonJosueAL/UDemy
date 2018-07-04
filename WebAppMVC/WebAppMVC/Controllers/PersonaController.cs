using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            List<Persona> vListPersona = new List<Persona>();

            vListPersona.Add(CrearPersona(1, "Edson", "Alarcón", "López"));
            vListPersona.Add(CrearPersona(1, "Josue", "Zamora", "Andreik"));
            vListPersona.Add(CrearPersona(1, "Ruztek", "Mora", "Pierre"));
            vListPersona.Add(CrearPersona(1, "Matias", "Almeyda", "Pizarrinni"));

            return View(vListPersona);
        }

        private Persona CrearPersona(int pvIntCodigo, string pvStrNombre, string pvStrApePat, string pvStrApeMat)
        {
            Persona vEntPersona = new Persona();

            vEntPersona.Codigo = pvIntCodigo;
            vEntPersona.Nombre = pvStrNombre;
            vEntPersona.ApePat = pvStrApePat;
            vEntPersona.ApeMat = pvStrApeMat;

            return (vEntPersona);
        }
    }
}