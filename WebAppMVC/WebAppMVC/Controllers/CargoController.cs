using System.Linq;
using System.Web.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class CargoController : Controller
    {
        PracticaEntities vEntPracticaEntities = new PracticaEntities();

        // GET: Cargo
        public ActionResult Index()
        {
            var vLstCargos = vEntPracticaEntities.CARGOS;

            return View(vLstCargos.ToList());
        }

        public ActionResult ListadoMaestraCargos()
        {
            var vLstCargos = vEntPracticaEntities.CARGOS;

            return View(vLstCargos.ToList());
        }

        public ActionResult UsuarioPorCargo(string pvStrCargo)
        {
            var vModelo = from p in vEntPracticaEntities.USUARIOS where p.CARGOS.Cargo == pvStrCargo select p;

            return View(vModelo.ToList());
        }

        public ActionResult ListadoUsuarioConDescCargo()
        {
            var vModelo = from p in vEntPracticaEntities.USUARIOS
                          join c in vEntPracticaEntities.CARGOS
                            on p.IDCargo equals c.IDCargo
                          select new Usuario
                          {
                              IDUsuario = p.IDUsuario,
                              NombreUsuario = p.NombreUsuario,
                              Cargo = c.Cargo
                          };

            return View(vModelo.ToList());
        }
    }
}