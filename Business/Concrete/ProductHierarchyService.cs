using Business.Abstract;
using Business.Contants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete.CivilTable;
using Entities.Concrete.CivilTable.Procedure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductHierarchyService : IProductHierarchyService
    {
        private IProductHierarchyDal _productHierarchy;

        public ProductHierarchyService(IProductHierarchyDal productHierarchy)
        {
            _productHierarchy = productHierarchy;
        }

        public async Task<IDataResult<List<sp_vm_GetAllAttributeByHierarchyId>>> GetAllAttributeByHierarchyId(int productHiearchyId)
        {
            try
            {
                var result = await _productHierarchy.GetAllAttributeByHierarchyId(productHiearchyId);

                return new SuccessDataResult<List<sp_vm_GetAllAttributeByHierarchyId>>(result.ToList());

            }
            catch
            {

                return new ErrorDataResult<List<sp_vm_GetAllAttributeByHierarchyId>>(Messages.ProductNotFound);
            }
        }

        public async Task<IDataResult<List<sp_vm_GetAllFabricType>>> GetAllFabricType()
        {
            try
            {
                var result = await _productHierarchy.GetAllFabricType();

                return new SuccessDataResult<List<sp_vm_GetAllFabricType>>(result.ToList());

            }
            catch
            {

                return new ErrorDataResult<List<sp_vm_GetAllFabricType>>(Messages.ProductNotFound);
            }
        }

        public async Task<IDataResult<List<sp_vm_GetAllProductPartType>>> GetAllProductPartType()
        {
            try
            {
                var result = await _productHierarchy.GetAllProductPartType();

                return new SuccessDataResult<List<sp_vm_GetAllProductPartType>>(result.ToList());

            }
            catch
            {

                return new ErrorDataResult<List<sp_vm_GetAllProductPartType>>(Messages.ProductNotFound);
            }
        }

        public async Task<IDataResult<List<sp_vm_GetAttrContentsByHiearIdandAttrCode>>> GetAttrContentsByHierarchyIdandAttrCode(int productHiearchyId, int AttributeTypeCode)
        {
            try
            {
                var result = await _productHierarchy.GetAttrContentsByHierarchyIdandAttrCode(productHiearchyId,AttributeTypeCode);

                return new SuccessDataResult<List<sp_vm_GetAttrContentsByHiearIdandAttrCode>>(result.ToList());

            }
            catch (System.Exception e)
            {

                return new ErrorDataResult<List<sp_vm_GetAttrContentsByHiearIdandAttrCode>>(Messages.ProductNotFound);
            }
        }

        public async Task<IDataResult<List<ProductHierarchy>>> GetAllHierarchy()
        {
            var result = await _productHierarchy.GetAllHierarchy();
            return new SuccessDataResult<List<ProductHierarchy>>(result.ToList());
        }

        public async Task<IDataResult<List<sp_vm_GetProductDimSetByHierarchyId>>> GetProductDimSetByHierarchyId(int productHiearchyId)
        {
           
            try
            {
                var result = await _productHierarchy.GetProductDimSetByHierarchyId(productHiearchyId);

                return new SuccessDataResult<List<sp_vm_GetProductDimSetByHierarchyId>>(result.ToList());

            }
            catch
            {

                return new ErrorDataResult<List<sp_vm_GetProductDimSetByHierarchyId>>(Messages.ProductNotFound);
            }
           
        }

        public  async Task<IDataResult<List<sp_vm_GetAllCommercialRole>>> GetAllCommercialRole()
        {
            try
            {
                var result = await _productHierarchy.sp_vm_GetAllCommercialRole();

                return new SuccessDataResult<List<sp_vm_GetAllCommercialRole>>(result.ToList());

            }
            catch(Exception e)
            {

                return new ErrorDataResult<List<sp_vm_GetAllCommercialRole>>(e.ToString());
            }
        }

        public async Task<IDataResult<List<sp_vm_GetAllPriceLevel>>> GetAllPriceLevel()
        {
            try
            {
                var result = await _productHierarchy.sp_vm_GetAllPriceLevel();

                return new SuccessDataResult<List<sp_vm_GetAllPriceLevel>>(result.ToList());

            }
            catch
            {

                return new ErrorDataResult<List<sp_vm_GetAllPriceLevel>>(Messages.ProductNotFound);
            }
        }

        
    }
}
