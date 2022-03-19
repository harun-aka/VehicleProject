using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IDataResult<List<CarDto>> GetAllCarDto()
        {
            return new SuccessDataResult<List<CarDto>>(_carDal.GetAllCarDto(), Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetAllByColor(string color)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAllByColor(color), Messages.CarsListedByColor);
        }

        public IResult Delete(int carId)
        {
            IDataResult<Car> result = GetById(carId);
            if (!result.Success)
            {
                return new ErrorResult(result.Message);
            }
            Car car = result.Data;
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IResult ToggleHighlights(int carId)
        {
            IDataResult<Car> result = GetById(carId);
            if (!result.Success)
            {
                return new ErrorResult(result.Message);
            }
            Car car = result.Data;
            car.HeadLights = car.HeadLights ? false : true;
            _carDal.Update(car);
            return new SuccessResult(Messages.CarHighlightsToggled);
        }

        public IDataResult<Car> GetById(int carId)
        {
            Car car = _carDal.Get(car => car.Id == carId);
            if (car == null)
            {
                return new ErrorDataResult<Car>(Messages.CarNotFound);
            }
            return new SuccessDataResult<Car>(car);
        }
    }
}
