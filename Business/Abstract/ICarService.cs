using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<CarDto>> GetAllCarDto();
        IDataResult<List<Car>> GetAllByColor(string color);
        IDataResult<Car> GetById(int carId);
        IResult Delete(int carId);
        IResult ToggleHighlights(int carId);
    }
}
