using System.ComponentModel.DataAnnotations;

namespace WebApp.Controllers.Models
{
    public class Alumno
    {
        [Key]
        public string idAlumno { get; set; }

        public string codigo { get; set; }

        public string nombre  { get; set; }

        public string direccion { get; set; }

        public string telefono { get; set; }

        public string email { get; set; }
    }
    
}
