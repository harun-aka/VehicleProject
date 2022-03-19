using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBoatDal : IEntityRepository<Boat>
    {
        List<BoatDto> GetAllBoatDto();
        List<Boat> GetAllByColor(string color);
    }
}
