using Data;
using Models.Trail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TrailService
    {
        public bool CreateTrail(TrailCreate model)
        {
            var entity =
                new Trail()
                {
                    ParkId = model.ParkId,
                    TrailName = model.TrailName,
                    TrailLength = model.TrailLength,
                    TrailType = model.TrailType,
                    TrailDescription = model.TrailDescription
                  
                };
            using(var ctx = new ApplicationDbContext())
            {
                ctx.Trails.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public TrailDetail GetTrailDetailsById(int id)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Trails
                    .Single(trail => trail.TrailId == id && trail.IsDeleted == false);

                return
                    new TrailDetail
                    {
                        TrailId = entity.TrailId,
                        ParkId = entity.ParkId,
                        TrailName = entity.TrailName,
                        TrailLength = entity.TrailLength,
                        TrailType = entity.TrailType,
                        TrailDescription = entity.TrailDescription
                        
                    };
            }
        }

        public IEnumerable<TrailDetail> GetAllTrailsByParkId(int parkId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Trails
                    .Where(park => park.ParkId == parkId)
                    .Select(
                        trail =>
                        new TrailDetail
                        {
                          TrailId = trail.TrailId,
                          TrailName = trail.TrailName,
                          TrailLength = trail.TrailLength,
                          TrailType = trail.TrailType,
                          TrailDescription = trail.TrailDescription
                        }
                     );

                return query.ToArray();

            }
                

        }

        public bool UpdateTrail(TrailEdit model)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Trails
                        .Single(trail => trail.TrailId == model.TrailId && trail.IsDeleted == false);
                entity.ParkId = model.ParkId;
                entity.TrailName = model.TrailName;
                entity.TrailLength = model.TrailLength;
                entity.TrailType = model.TrailType;
                entity.TrailDescription = model.TrailDescription;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteTrail(int trailId)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Trails
                        .Single(trail => trail.TrailId == trailId);
                if(!entity.IsDeleted)
                {
                    entity.IsDeleted = true;
                }

                return ctx.SaveChanges() == 1;
            }
        }

    }
}
