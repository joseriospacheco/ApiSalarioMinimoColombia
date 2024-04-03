using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalarioMinimoColombia.Servicios;

namespace SalarioMinimoColombia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AniosController : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<int>> Get()
        {
            return SalarioMinimoService.Salarios.Select(x=>x.Anio).ToList();
        }

    }
}
