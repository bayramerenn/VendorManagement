using Core.DataAccess.EfEntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete.CivilTable;
using Entities.Concrete.CivilTable.Procedure;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.CivilDal
{
    public class EfProductHierarchyDal : EfEntityRepository<ProductHierarchy, CivilContext>, IProductHierarchyDal
    {
        public async Task<IList<sp_vm_GetAllAttributeByHierarchyId>> GetAllAttributeByHierarchyId(int productHiearchyId)
        {
            using (var context = new CivilContext())
            {
                return await context.sp_vm_GetAllAttributeByHierarchyId.FromSqlRaw($"EXEC sp_vm_GetAllAttributeByHierarchyId @ProductHierarchyFilter={productHiearchyId}").ToListAsync();
            }
        }

        public async Task<IList<sp_vm_GetAllFabricType>> GetAllFabricType()
        {
            using (var context = new CivilContext())
            {
                return await context.sp_vm_GetAllFabricType.FromSqlRaw($"EXEC sp_vm_GetAllFabricType").ToListAsync();
            }
        }

        public async Task<IList<ProductHierarchy>> GetAllHierarchy()
        {
            using (var context = new CivilContext())
            {
                var result = await context.ProductHierarchy.FromSqlRaw("Exec sp_vm_GetAllHierarchy").ToListAsync();
                return result;
            }
        }
       

        public async Task<IList<sp_vm_GetAllProductPartType>> GetAllProductPartType()
        {
            using (var context = new CivilContext())
            {
                return await context.sp_vm_GetAllProductPartType.FromSqlRaw($"EXEC sp_vm_GetAllProductPartType").ToListAsync();
            }
        }

        public async Task<IList<sp_vm_GetAttrContentsByHiearIdandAttrCode>> GetAttrContentsByHierarchyIdandAttrCode(int productHiearchyId, int AttributeTypeCode)
        {
            using (var context = new CivilContext())
            {
                return await context.sp_vm_GetAttrContentsByHiearIdandAttrCode.FromSqlRaw($"EXEC sp_vm_GetAttrContentsByHiearIdandAttrCode @ProductHierarchyFilter={productHiearchyId},@AttributeTypeCode={AttributeTypeCode}").ToListAsync();
            }
        }

        public async Task<IList<sp_vm_GetProductDimSetByHierarchyId>> GetProductDimSetByHierarchyId(int productHiearchyId)
        {
            using (var context = new CivilContext())
            {
                var data = await context.sp_vm_GetProductDimSetByHierarchyId.FromSqlRaw($"EXEC sp_vm_GetProductDimSetByHierarchyId @ProductHierarchyId={productHiearchyId}").ToListAsync();
                return data;
            }
        }

     

        public async Task<IList<sp_vm_GetAllCommercialRole>> sp_vm_GetAllCommercialRole()
        {
            using (var context = new CivilContext())
            {
                return await context.sp_vm_GetAllCommercialRole.FromSqlRaw($"EXEC sp_vm_GetAllCommercialRole").ToListAsync();
            }
        }

        public async Task<IList<sp_vm_GetAllPriceLevel>> sp_vm_GetAllPriceLevel()
        {
            using (var context = new CivilContext())
            {
                return await context.sp_vm_GetAllPriceLevel.FromSqlRaw($"EXEC sp_vm_GetAllPriceLevel").ToListAsync();
            }
        }
    }
}
