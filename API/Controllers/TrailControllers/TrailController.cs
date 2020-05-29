using Models.Trail;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers.TrailControllers
{
    [Authorize]
    public class TrailController : ApiController
    {
        [HttpPost]
        public IHttpActionResult PostTrail(TrailCreate trail)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            TrailService service = new TrailService();

            if (!service.CreateTrail(trail))
                return InternalServerError();

            return Ok();


        }

        [HttpGet]
        public IHttpActionResult GetTrailDetailsById(int trailId)
        {
            TrailService trailService = new TrailService();
            var trail = trailService.GetTrailDetailsById(trailId);
            return Ok(trail);
        }


        [HttpGet]
        public IHttpActionResult GetTrailsByParkId(int parkId)
        {
            TrailService trailService = new TrailService();
            var trail = trailService.GetAllTrailsByParkId(parkId);
            return Ok(trail);
        }



        [HttpPut]
        public IHttpActionResult UpdateTrail(TrailEdit trail)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            TrailService service = new TrailService();

            if (!service.UpdateTrail(trail))
                return InternalServerError();

            return Ok();
        }


        [HttpDelete]
        public IHttpActionResult DeleteTrail(int trailId)
        {
            TrailService service = new TrailService();

            if (!service.DeleteTrail(trailId))
                return InternalServerError();

            return Ok();
        }
    }
}
