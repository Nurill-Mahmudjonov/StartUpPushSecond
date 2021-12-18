using Microsoft.AspNetCore.Mvc;
using StartUpProject.DataLayer;
using StartUpProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StartUpProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private StartUpContext db;
        public CityController(StartUpContext _db)
        {
            db = _db;
        }
        // GET: api/<CityController>
        [HttpGet]
        public ActionResult<IEnumerable<City>> Get()
        {
            if (db.Cities==null)
            {
                return NotFound(db.Cities);
            }
            return Ok(db.Cities);
        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<City>> Get(Guid id)
        {
            var city = await db.Cities.FindAsync(id);
            if (city==null)
            {
                return NotFound(city);
            }
            return Ok(city);
        }

        // POST api/<CityController>
        [HttpPost]
        public async void Post(string Name)
        {
            await db.Cities.AddAsync(new City()
            {
                Id = Guid.NewGuid(),
                Name = Name
            });
            await db.SaveChangesAsync();
        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        public async void Put(Guid id, string Name)
        {
            var city =await db.Cities.FindAsync(id);
            if (city==null)
            {
                NotFound(city);
            }
            else
            {
                city.Name = Name;
            }
            await db.SaveChangesAsync();
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
