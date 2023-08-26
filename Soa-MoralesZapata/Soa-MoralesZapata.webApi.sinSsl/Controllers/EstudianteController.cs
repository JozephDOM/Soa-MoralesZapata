using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Soa_MoralesZapata.model;
namespace Soa_MoralesZapata.webApi.sinSsl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        [HttpPost("IngresarEstudiante")]
        public Estudiante CrearEstudiante(Estudiante estudiante)
        {
            return estudiante;
        }

        [HttpPost("ModificarEstudiante")]
        public Estudiante ModificarEstudiante(Estudiante estudiante)
        {
            return estudiante;
        }

        [HttpPost("RetirarEstudiante")]
        public Estudiante RetirarEstudiante(Estudiante estudiante)
        {
            return estudiante;
        }

        [HttpPost("ConsultarEstudiante")]
        public Estudiante ConsultarEstudiante(Estudiante estudiante)
        {
            return estudiante;
        }

    }
}
