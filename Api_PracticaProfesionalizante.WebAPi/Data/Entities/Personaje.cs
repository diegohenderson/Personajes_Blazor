using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api_PracticaProfesionalizante.WebAPi.Data.Entities
{
    public class Personaje
    {
        //El campo id por default, lleva la etiqueta de primary key.
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Localizacion { get; set; }


    }
}
