using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, VehicleProjectContext>, ICarDal
    {
        public List<Car> GetAllByColor(string color)
        {
                using (VehicleProjectContext context = new VehicleProjectContext())
                {
                    var result = from ca in context.Cars
                                 join co in context.Colors
                                 on ca.ColorId equals co.Id
                                 where co.Name == color
                                 select new Car
                                 {
                                     Id = ca.Id,
                                     ColorId = ca.ColorId,
                                     HeadLights = ca.HeadLights,
                                     Wheel = ca.Wheel,
                                 };
                    return result.ToList();
                }
        }

        public List<CarDto> GetAllCarDto()
        {
            using (VehicleProjectContext context = new VehicleProjectContext())
            {
                var result = from ca in context.Cars
                             join co in context.Colors
                             on ca.ColorId equals co.Id 
                             select new CarDto
                             {
                                 Id = ca.Id,
                                 ColorName = co.Name,
                                 HeadLights = ca.HeadLights,
                                 Wheel = ca.Wheel,
                             };
                return result.ToList();
            }
        }
    }
}
