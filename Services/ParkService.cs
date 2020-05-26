using Data;
using Models;
using Models.Park;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ParkService
    {
        public bool CreatePark(ParkCreate model)
        {
            var entity =
                new Park()
                {
                    Name = model.Name,
                    City = model.City,
                    State = model.State,
                    ParkDescription = model.ParkDescription
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Parks.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public ParkDetail GetParkDetailsById(int id)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Parks
                    .Single(park => park.ParkId == id);
                return
                    new ParkDetail
                    {
                        ParkId = entity.ParkId,
                        Name = entity.Name,
                        City = entity.City,
                        State = entity.State,
                        ParkDescription = entity.ParkDescription
                    };
            }
        }

        public bool UpdatePark(ParkEdit model)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Parks
                        .Single(park => park.ParkId == model.ParkId);

                entity.Name = model.Name;
                entity.City = model.City;
                entity.State = model.State;
                entity.ParkDescription = model.ParkDescription;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeletePark(int parkId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Parks
                        .Single(park => park.ParkId == parkId);

                if(entity.IsDeleted)
                {
                    entity.IsDeleted = false;
                }
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
