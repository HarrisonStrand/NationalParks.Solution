using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Parks.Models;
using Microsoft.EntityFrameworkCore;

namespace Parks.Controllers
{
    [ApiVersion("1.0")] //NOT DEFAULT VERSION
    [Route("api/nationalparksv1")]
    [ApiController]
    public class NationalParksV1Controller : ControllerBase
    {
        private ParksContext _db;
        public NationalParksV1Controller(ParksContext db)
        {
            _db = db;
        }

        //GET api/nationalparks?api-version=1.0&name=Glacier Bay
        [HttpGet]
        public ActionResult<IEnumerable<NationalPark>> Get(string name)
        {

            var query = _db.NationalParks.AsQueryable();
            if (name != null)
            {
                query = query.Where(entry => entry.Name == name);
            }
            return query.ToList();
        }
    }

    [ApiVersion("2.0")] //DEFAULT VERSION
    [Route("api/nationalparksv2")]
    [ApiController]
    public class NationalParksV2Controller : ControllerBase
    {
        private ParksContext _db;
        public NationalParksV2Controller(ParksContext db)
        {
            _db = db;
        }

        //GET api/nationalparks?name=Glacier Bay
        [HttpGet]
        public ActionResult<IEnumerable<NationalPark>> Get(string name, string location)
        {
            var query = _db.NationalParks.AsQueryable();
			if (name != null)
            {
                query = query.Where(entry => entry.Name == name);
            }
			if (location != null)
            {
                query = query.Where(entry => entry.Location == location);
            }
            return query.ToList();
        }


        // POST api/nationalparks
        [HttpPost]
        public void Post([FromBody] NationalPark nationalPark)
        {
            _db.NationalParks.Add(nationalPark);
            _db.SaveChanges();
        }

        //Get api/nationalparks/5
        [HttpGet("{id}")]
        public ActionResult<NationalPark> Get(int id)
        {
            return _db.NationalParks.FirstOrDefault(entry => entry.Id == id);
        }

        // PUT api/nationalparks/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] NationalPark nationalPark)
        {
            nationalPark.Id = id;
            _db.Entry(nationalPark).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/nationalparks/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var nationalParkToDelete = _db.NationalParks.FirstOrDefault(entry => entry.Id == id);
            _db.NationalParks.Remove(nationalParkToDelete);
            _db.SaveChanges();
        }
    }
}
