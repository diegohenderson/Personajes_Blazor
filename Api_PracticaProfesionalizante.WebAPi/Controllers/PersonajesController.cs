using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_PracticaProfesionalizante.WebAPi.Data;
using Api_PracticaProfesionalizante.WebAPi.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api_PracticaProfesionalizante.WebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonajesController : ControllerBase
    {
        private readonly ApiContext context;

        public PersonajesController(ApiContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Personaje>>Get()
        {

        }
    }
}