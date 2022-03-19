using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBusDal : IEntityRepository<Bus>
    {
        List<BusDto> GetAllBusDto();
        List<Bus> GetAllByColor(string color);
    }
}
