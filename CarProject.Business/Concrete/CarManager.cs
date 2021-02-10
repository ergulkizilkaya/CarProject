﻿using CarProject.Business.Abstract;
using CarProject.Business.Utilities;
using CarProject.Business.ValidationRules.FluentValidation;
using CarProject.DataAccess.Abstract;
using CarProject.Entities.Concrete;
using CarProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarProject.Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            ValidationTool.Validate(new CarValidator(), car);
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<CarDetailDto> GetCarsByBrandId(int p)
        {
            return _carDal.GetCarDetails(c=>c.BrandId ==  p);
        }

        public List<CarDetailDto> GetCarsByColorId(int p)
        {
            return _carDal.GetCarDetails(c => c.ColorId == p);
        }

        public void Update(Car car)
        {
            ValidationTool.Validate(new CarValidator(), car);
            _carDal.Update(car);
        }
    }
}
