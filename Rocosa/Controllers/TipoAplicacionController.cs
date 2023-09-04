using Microsoft.AspNetCore.Mvc;
using Rocosa.Data;
using Rocosa.Models;

namespace Rocosa.Controllers
{
    public class TipoAplicacionController : Controller
    {

        private readonly ApplicationDbContext _db;

        public TipoAplicacionController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<TipoAplicacion> objList = _db.TipoAplicacion;

            return View(objList);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(TipoAplicacion tipoAplicacion)
        {
            _db.TipoAplicacion.Add(tipoAplicacion);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
