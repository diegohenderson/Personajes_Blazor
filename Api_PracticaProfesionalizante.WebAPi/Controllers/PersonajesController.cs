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
        #region Get
        //Get de La lista Entera.
        [HttpGet]
        public ActionResult<IEnumerable<Personaje>>Get()
        {
            return context.Personajes.ToList();
        }

        //por id.
        [HttpGet("{id}", Name = "ObtenerPersonajePorID")]
        public ActionResult<Personaje> Get(int id)
        {
            var personaje = context.Personajes.FirstOrDefault(p => p.Id == id);
            if (personaje == null)
            {
                return NotFound();

            }
            return personaje;
        }

        #endregion
        #region Post

        [HttpPost]     
        public async Task<ActionResult<Personaje>> Post([FromBody] Personaje personaje)
        {
            
            await context.Personajes.AddAsync(pais);
            
            await context.SaveChangesAsync();
            return new CreatedAtRouteResult("obtenerPersonajePorId", new { id = personaje.Id }, personaje);
            

        }
        #endregion

    }
}