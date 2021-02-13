using Core.DataAccess.EfEntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete.VendorManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.VMDal
{
    public class EfProductVariantDal:EfEntityRepository<ProductVariant,VMContext>,IProductVariantDal
    {
    }
}
