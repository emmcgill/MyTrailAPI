using Models.Park;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers.ParkControllers
{
    [Authorize]
    public class ParkController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Post(ParkCreate park)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            ParkService service = new ParkService();

            if (!service.CreatePark(park))
                return InternalServerError();

            return Ok();


        }

        [HttpGet]
        public IHttpActionResult GetParkDetailsById(int parkId)
        {
            ParkService parkService = new ParkService();
            var park = parkService.GetParkDetailsById(parkId);
            return Ok(park);
        }


        
        [HttpPut]
        public IHttpActionResult Put(ParkEdit park)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            ParkService service = new ParkService();

            if (!service.UpdatePark(park))
                return InternalServerError();

            return Ok();
        }

        
        [HttpDelete]
        public IHttpActionResult Delete(int parkId)
        {
            ParkService service = new ParkService();

            if (!service.DeletePark(parkId))
                return InternalServerError();

            return Ok();
        }
    }
}
