using Core.DataAccess;
using Entities.Concrete.VendorManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDescriptionDal: IEntityRepository<ProductDescription>
    {
    }
}
