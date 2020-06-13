using System.Collections.Generic;
using System.Linq;
using api_rest_netcore.entities;

namespace api_rest_netcore.repositorios
{
    public class RPAlumnos
    {
        public static List<alumno> _listaAlumnos = new List<alumno>()
        {
            new alumno() { dni = 135245, nombre = "Alumno 1" , apellido = "Apellido 1", curso = "analista de sistemas", año = "2020"},
            new alumno() { dni = 245425, nombre = "Alumno 2" , apellido = "Apellido 2", curso = "analista de sistemas", año = "2020"},
            new alumno() { dni = 324556, nombre = "Alumno 3" , apellido = "Apellido 3", curso = "analista de sistemas", año = "2020"}
        };

        public IEnumerable<alumno> ObtenerAlumnos()
        {
            return _listaAlumnos;
        }

        public alumno ObtenerAlumno(int dni)
        {
            var alumno = _listaAlumnos.Where(alu => alu.dni == dni);

            return alumno.FirstOrDefault();
        }

        public void Agregar(alumno nuevoAlumno)
        {
            _listaAlumnos.Add(nuevoAlumno);
        }
    }
}
