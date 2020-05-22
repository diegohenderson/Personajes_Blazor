using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api_PracticaProfesionalizante.WebAPi.Data.Entities
{
    public class Personaje
    {
        public int Id { get; set; }
        
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Localizacion { get; set; }
        public string Origen { get; set; }

    }
}
