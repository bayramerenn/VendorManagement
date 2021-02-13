using Business.Abstract;
using Business.Contants;
using Business.Dtos;
using Core.Utilities.IoC;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete.CivilTable.Procedure;
using Entities.Concrete.VendorManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductService : IProductService
    {
        private IProductDal _productDal;
        private IProductDescriptionService _productDescriptionService;
        private IProductAttributeService _productAttributeService;
        private IProductVariantService _productVariantService;
        private IProductColorFabricBlendService _productColorFabricBlendService;
        private IUserService _userService;

        public ProductService(IProductDal productDal, IProductDescriptionService productDescriptionService, IProductAttributeService productAttributeService, IProductVariantService productVariantService, IProductColorFabricBlendService productColorFabricBlendService, IHttpContextAccessor httpContextAccessor, IUserService userService)
        {
            _productDal = productDal;
            _productDescriptionService = productDescriptionService;
            _productAttributeService = productAttributeService;
            _productVariantService = productVariantService;
            _productColorFabricBlendService = productColorFabricBlendService;
            _userService = userService;
        }

        //  [ValidationAspect(typeof(ProductCreateDtoValidator))]
        //[TransactionScopeAspect]
        public async Task<IResult> AddAsync(ProductCreateDto productCreateDto)
        {
           var productDto = await FillInData(productCreateDto);

            await _productColorFabricBlendService.AddRangeAsync(productDto.ProductColorFabricBlends);
            await _productVariantService.AddRangeAsync(productDto.ProductVariants);

            await _productDal.AddAsync(productCreateDto.Product);
            await _productDescriptionService.AddAsync(productCreateDto.ProductDescription);
            await _productAttributeService.AddRangeAsync(productCreateDto.ProductAttributes);

            return new SuccessResult(Messages.ProductAdded);
        }

        private async Task<ProductCreateDto> FillInData(ProductCreateDto productCreateDto)
        {
            var user =await _userService.GetUserName();

            productCreateDto.Product.CreatedUserName = user;
            productCreateDto.Product.LastUpdatedUserName = user;

            productCreateDto.ProductAttributes.ForEach(f =>
            {
                f.CreatedUserName = user;
                f.LastUpdatedUserName = user;
                f.ItemCode = productCreateDto.Product.ItemCode;
                f.ItemTypeCode = productCreateDto.Product.ItemTypeCode;
            });

            productCreateDto.ProductColorFabricBlends.ForEach(f =>
            {
                f.CreatedUserName = user;
                f.LastUpdatedUserName = user;
                f.ItemCode = productCreateDto.Product.ItemCode;
                f.ItemTypeCode = productCreateDto.Product.ItemTypeCode;
            });

            productCreateDto.ProductDescription.CreatedUserName = user;
            productCreateDto.ProductDescription.LastUpdatedUserName = user;
            productCreateDto.ProductDescription.ItemCode = productCreateDto.Product.ItemCode;
            productCreateDto.ProductDescription.ItemTypeCode = productCreateDto.Product.ItemTypeCode;

            productCreateDto.ProductVariants.ForEach(f =>
            {
                f.CreatedUserName = user;
                f.LastUpdatedUserName = user;
                f.ItemCode = productCreateDto.Product.ItemCode;
                f.ItemTypeCode = productCreateDto.Product.ItemTypeCode;
            });

            return productCreateDto;
        }

        public async Task<IDataResult<sp_vm_LastProductNumber>> GetLastProductNumberAsync(string productNumber)
        {
            return new SuccessDataResult<sp_vm_LastProductNumber>(await _productDal.sp_LastProductNumber(productNumber));
        }

        public async Task<IDataResult<List<Product>>> GetProductsAsync()
        {
            var result = await _productDal.GetListAsync();
            return new SuccessDataResult<List<Product>>(result.ToList());
        }

        public IResult GetUsers()
        {
            var user = _userService.GetUserName();
            return new SuccessResult(user.Result);
        }
    }
}
