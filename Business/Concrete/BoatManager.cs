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
    public class BoatManager : IBoatService
    {

        IBoatDal _boatDal;

        public BoatManager(IBoatDal boatDal)
        {
            _boatDal = boatDal;
        }

        public IDataResult<List<BoatDto>> GetAllBoatDto()
        {
            return new SuccessDataResult<List<BoatDto>>(_boatDal.GetAllBoatDto(), Messages.BoatsListed);
        }

        public IDataResult<List<Boat>> GetAllByColor(string color)
        {
            return new SuccessDataResult<List<Boat>>(_boatDal.GetAllByColor(color), Messages.BoatsListedByColor);
        }
    }
}
