﻿using CarProject.Entities.Concrete;
using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarProject.DataAccess.Abstract
{
    public interface IBrandDal:IEntityRepository<Brand>
    {
    }
}