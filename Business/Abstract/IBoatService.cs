using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBoatService
    {
        IDataResult<List<BoatDto>> GetAllBoatDto();
        IDataResult<List<Boat>> GetAllByColor(string color);
    }
}
