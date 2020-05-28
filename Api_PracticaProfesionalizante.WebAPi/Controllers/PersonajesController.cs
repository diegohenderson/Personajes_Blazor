using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_PracticaProfesionalizante.WebAPi.Data;
using Api_PracticaProfesionalizante.WebAPi.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public ActionResult<List<Personaje>>Get()
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
        /*[HttpPost]
        public ActionResult<Personaje> Post([FromBody]Personaje personaje)
        {
            context.Personajes.Add(personaje);
            context.SaveChanges();
            return personaje;
        }*/

        [HttpPost]     
        public async Task<ActionResult<Personaje>> Post([FromBody] Personaje personaje)
        {
            
            await context.Personajes.AddAsync(personaje);
            
            await context.SaveChangesAsync();
            return new CreatedAtRouteResult("obtenerPersonajePorId", new { id = personaje.Id }, personaje);
            

        }

        #endregion
        #region Put
        [HttpPut("{id}")]
        public ActionResult<Personaje> Put(int id, [FromBody] Personaje personaje)
        {
            if (id != personaje.Id)
            {
                return BadRequest();
            }
            context.Entry(personaje).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();

        }
        #endregion
        #region Delete

        [HttpDelete("{id}")]
        public ActionResult<Personaje> Delete(int id)
        {
            var personaje = context.Personajes.FirstOrDefault(p => p.Id == id);
            if (personaje == null)
            {
                return NotFound();
            }
            context.Personajes.Remove(personaje);
            context.SaveChanges();
            return Ok();
        }
        #endregion

    }
}