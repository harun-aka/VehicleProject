using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BusManager : IBusService
    {
        IBusDal _busDal;

        public BusManager(IBusDal busDal)
        {
            _busDal = busDal;
        }

        public IDataResult<List<BusDto>> GetAllBusDto()
        {
            return new SuccessDataResult<List<BusDto>>(_busDal.GetAllBusDto(), Messages.BusesListed);
        }

        public IDataResult<List<Bus>> GetAllByColor(string color)
        {
            return new SuccessDataResult<List<Bus>>(_busDal.GetAllByColor(color), Messages.BusesListedByColor);
        }

    }
}
