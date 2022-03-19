using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBoatDal : EfEntityRepositoryBase<Boat, VehicleProjectContext>, IBoatDal
    {
        public List<Boat> GetAllByColor(string color)
        {
            using (VehicleProjectContext context = new VehicleProjectContext())
            {
                var result = from b in context.Boats
                             join co in context.Colors
                             on b.ColorId equals co.Id 
                             where co.Name == color
                             select new Boat
                             {
                                 Id = b.Id,
                                 ColorId = b.ColorId,
                             };
                return result.ToList();
            }
        }

        public List<BoatDto> GetAllBoatDto()
        {
            using (VehicleProjectContext context = new VehicleProjectContext())
            {
                var result = from ca in context.Boats
                             join co in context.Colors
                             on ca.ColorId equals co.Id into bcTemp
                             from bc in bcTemp.DefaultIfEmpty()
                             select new BoatDto
                             {
                                 Id = ca.Id,
                                 ColorName = bc.Name
                             };
                return result.ToList();
            }
        }
    }
}
