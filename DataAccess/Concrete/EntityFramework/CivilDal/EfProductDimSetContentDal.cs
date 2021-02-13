using Core.DataAccess.EfEntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete.CivilTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.CivilDal
{
    public class EfProductDimSetContentDal : EfEntityRepository<prProductDimSetContent, CivilContext>, IProductDimSetContentDal
    {
    }
}
