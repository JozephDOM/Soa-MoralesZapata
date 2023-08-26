using Microsoft.AspNetCore.Mvc;
using Soa_MoralesZapata.model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Soa_MoralesZapata.webApi.ssl.Controllers
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
