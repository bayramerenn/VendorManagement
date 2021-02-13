using Core.DataAccess.EfEntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete.CivilTable.Procedure;
using Entities.Concrete.VendorManagement;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.VMDal
{
    public class EfProductDal : EfEntityRepository<Product, VMContext>, IProductDal
    {
        public async Task<sp_vm_LastProductNumber> sp_LastProductNumber(string productNumber)
        {
            using (var context = new CivilContext())
            {
                var result = await context.sp_vm_LastProductNumber.FromSqlRaw($"exec sp_vm_LastProductNumber @Suffix='{productNumber}'").ToListAsync();

                return result.FirstOrDefault();
            }
        }
    }
}
