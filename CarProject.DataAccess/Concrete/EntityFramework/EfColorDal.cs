using CarProject.DataAccess.Abstract;
using CarProject.Entities.Concrete;
using Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarProject.DataAccess.Concrete.EntityFramework
{
    public class EfColorDal:EfEntityRepositoryBase<Color,CarProjectContext>,IColorDal
    {
    }
}
