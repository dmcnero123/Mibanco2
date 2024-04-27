using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mibanco2.Data;
using Microsoft.EntityFrameworkCore;
using Mibanco2.Models;
using Microsoft.AspNetCore.Identity;


namespace Mibanco2.Controllers
{
    public class MostrarController : Controller
    {
        private readonly ILogger<MostrarController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public MostrarController(ILogger<MostrarController> logger,
            ApplicationDbContext context,
            UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }
                  // GET: Mostrar/DatosCuenta

            public ActionResult Index()
            {
                return View();
            }

            /*[HttpPost]
            public IActionResult ConsultarDatos(Cuenta datosCuenta)
            {
                // Aquí puedes acceder a los datos de cuenta
                int idCuenta = datosCuenta.Id;
                string nombreTitular = datosCuenta.NombreTitular;
                string email = datosCuenta.Email;
                string tipoCuenta = datosCuenta.TipoCuenta;
                decimal saldo = datosCuenta.SaldoInicial;

                // Luego, puedes hacer lo que necesites con estos datos, como guardarlos en la base de datos, procesarlos, etc.

                // Devuelve una respuesta, por ejemplo, un mensaje de éxito
                return Content("Datos de cuenta recibidos correctamente");
            }
            */
           /* [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View("Error!");
            }*/

        }
    }

