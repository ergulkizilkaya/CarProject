using CarProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarProject.Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
    }
}
