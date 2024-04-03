using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalarioMinimoColombia.Models;
using SalarioMinimoColombia.Servicios;

namespace SalarioMinimoColombia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalariosMinimosController : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<SalarioMinimo>> Get() {

            return SalarioMinimoService.Salarios.ToList();
        }

        [HttpGet("{anio}")]
        public ActionResult<List<SalarioMinimo>> Get(int anio)
        {

            var salario = SalarioMinimoService.Salarios.FirstOrDefault(x => x.Anio == anio);

            if (salario is not null) { 
            
                return Ok(salario);


            }

            return NotFound();
        }

    }
}
