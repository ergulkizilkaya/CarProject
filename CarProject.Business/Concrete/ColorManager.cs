using CarProject.Business.Abstract;
using CarProject.DataAccess.Abstract;
using CarProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarProject.Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }
    }
}
