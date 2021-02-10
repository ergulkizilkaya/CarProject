using CarProject.Business.Abstract;
using CarProject.DataAccess.Abstract;
using CarProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarProject.Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }
    }
}
