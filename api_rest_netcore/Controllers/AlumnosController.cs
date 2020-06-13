using Microsoft.AspNetCore.Mvc;
using api_rest_netcore.entities;
using api_rest_netcore.repositorios;

namespace api_rest_netcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            RPAlumnos rpAlu = new RPAlumnos();
            return Ok(rpAlu.ObtenerAlumnos());
        }

        [HttpGet("{dni}")]
        public IActionResult Get(int dni)
        {
            RPAlumnos rpAlu = new RPAlumnos();

            var aluRet = rpAlu.ObtenerAlumno(dni);

            if (aluRet == null)
            {
                var nf = NotFound("El Alumno " + dni.ToString() + " no existe.");
                return nf;
            }

            return Ok(aluRet);
        }

        [HttpPost("agregar")]
        public IActionResult AgregarAlumno(alumno nuevoAlumno)
        {
            RPAlumnos rpAlu = new RPAlumnos();
            rpAlu.Agregar(nuevoAlumno);
            return CreatedAtAction(nameof(AgregarAlumno), nuevoAlumno);
        }
    }
}