using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBusService
    {
        IDataResult<List<BusDto>> GetAllBusDto();
        IDataResult<List<Bus>> GetAllByColor(string color);
    }
}
