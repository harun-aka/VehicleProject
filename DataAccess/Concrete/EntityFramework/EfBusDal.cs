using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBusDal : EfEntityRepositoryBase<Bus, VehicleProjectContext>, IBusDal
    {
        public List<Bus> GetAllByColor(string color)
        {
            using (VehicleProjectContext context = new VehicleProjectContext())
            {
                var result = from b in context.Buses
                             join co in context.Colors
                             on b.ColorId equals co.Id
                             where co.Name == color
                             select new Bus
                             {
                                 Id = b.Id,
                                 ColorId = b.ColorId,
                             };
                return result.ToList();
            }
        }

        public List<BusDto> GetAllBusDto()
        {
            using (VehicleProjectContext context = new VehicleProjectContext())
            {
                var result = from ca in context.Buses
                             join co in context.Colors
                             on ca.ColorId equals co.Id into bcTemp
                             from bc in bcTemp.DefaultIfEmpty()
                             select new BusDto
                             {
                                 Id = ca.Id,
                                 ColorName = bc.Name
                             };
                return result.ToList();
            }
        }
    }
}
