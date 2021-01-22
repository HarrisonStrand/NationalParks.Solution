using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Parks.Models;
using Microsoft.EntityFrameworkCore;

namespace Parks.Controllers
{
    [ApiVersion("1.0")] // NOT DEFAULT VERSION
    [Route("api/stateparksv1")]
    [ApiController]
    public class StateParksV1Controller : ControllerBase
    {
        private ParksContext _db;
        public StateParksV1Controller(ParksContext db)
        {
            _db = db;
        }

        //GET api/stateparks?api-version=1.0&name=Glacier-Bay
        [HttpGet]
        public ActionResult<IEnumerable<StatePark>> Get(string name)
        {

            var query = _db.StateParks.AsQueryable();
            if (name != null)
            {
                query = query.Where(entry => entry.Name == name);
            }
            return query.ToList();
        }
    }

    [ApiVersion("2.0")] //DEFAULT VERSION
    [Route("api/stateparksv2")]
    [ApiController]
    public class StateParksV2Controller : ControllerBase
    {
        private ParksContext _db;
        public StateParksV2Controller(ParksContext db)
        {
            _db = db;
        }

        //GET api/stateparks?region=south coast
        [HttpGet]
        public ActionResult<IEnumerable<StatePark>> Get(string name, string region)
        {
            var query = _db.StateParks.AsQueryable();
			if (name != null)
            {
                query = query.Where(entry => entry.Name == name);
            }
			if (region != null)
            {
                query = query.Where(entry => entry.Region == region);
            }
            return query.ToList();
        }


        // POST api/stateparks
        [HttpPost]
        public void Post([FromBody] StatePark statePark)
        {
            _db.StateParks.Add(statePark);
            _db.SaveChanges();
        }

        //Get api/stateparks/5
        [HttpGet("{id}")]
        public ActionResult<StatePark> Get(int id)
        {
            return _db.StateParks.FirstOrDefault(entry => entry.Id == id);
        }

        // PUT api/stateparks/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] StatePark statePark)
        {
            statePark.Id = id;
            _db.Entry(statePark).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/stateparks/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var stateParkToDelete = _db.StateParks.FirstOrDefault(entry => entry.Id == id);
            _db.StateParks.Remove(stateParkToDelete);
            _db.SaveChanges();
        }
    }
}
