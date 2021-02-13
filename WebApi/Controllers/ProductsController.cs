using AutoMapper;
using Business.Abstract;
using Business.Dtos;
using Entities.Concrete.VendorManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Dtos;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductHierarchyService _productHierarchyService;
        private IColorService _colorService;
        private IProductService _productService;
        private IProductDimSetContentService _productDimSetContentService;



        public ProductsController(IProductHierarchyService productHierarchyService, IColorService colorService, IProductService productService, IProductDimSetContentService productDimSetContentService)
        {
            _productHierarchyService = productHierarchyService;
            _colorService = colorService;
            _productService = productService;
            _productDimSetContentService = productDimSetContentService;

          
        }

        [HttpGet("getallproducthiearchy")]
        public async Task<IActionResult> GetProductHiearchy()
        {
            var result = await _productHierarchyService.GetAllHierarchy();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getallproductcolor")]
        public async Task<IActionResult> GetProductColors()
        {
            var result = await _colorService.GetColorByColorCode();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getallproductdimsetbyhiearchyid")]
        public async Task<IActionResult> GetProductDimSet(int productHierarchyId)
        {
            var result = await _productHierarchyService.GetProductDimSetByHierarchyId(productHierarchyId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getallattributebyhierarchyid")]
        public async Task<IActionResult> GetAllAttributeByHierarchyId(int ProductHierarchyFilter)
        {
            var result = await _productHierarchyService.GetAllAttributeByHierarchyId(ProductHierarchyFilter);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getattrcontent")]
        public async Task<IActionResult> GetAttrContentsByHiearIdandAttrCode(int ProductHierarchyFilter, int attrCode)
        {
            var result = await _productHierarchyService.GetAttrContentsByHierarchyIdandAttrCode(ProductHierarchyFilter, attrCode);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getallfabrictype")]
        public async Task<IActionResult> GetAllFabricType()
        {
            var result = await _productHierarchyService.GetAllFabricType();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getallproductparttype")]
        public async Task<IActionResult> GetAllProductPartType()
        {
            var result = await _productHierarchyService.GetAllProductPartType();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getallpricelevel")]
        public async Task<IActionResult> GetAllPriceLevel()
        {
            var result = await _productHierarchyService.GetAllPriceLevel();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getallcommercialrole")]
        public async Task<IActionResult> GetAllCommercialRole()
        {
            var result = await _productHierarchyService.GetAllCommercialRole();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getlastproductnumber")]
        public async Task<IActionResult> GetLastProductNumber(string productNumber)
        {
            var result = await _productService.GetLastProductNumberAsync(productNumber);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getproducts")]
        public async Task<IActionResult> GetAllProduct()
        {
            var result = await _productService.GetProductsAsync();
           
            if (result.Success)
            {
                return Ok(result.Data) ;
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getproductdimsetcode")]
        public async Task<IActionResult> GetAllProduct(string productDimSetCode)
        {
            var result = await _productDimSetContentService.GetListAsync(productDimSetCode);

            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getusers")]
        public  IActionResult GetUserAction()
        {
           
            return Ok(_productService.GetUsers());
        }


        [HttpPost("addproduct")]
        public async Task<IActionResult> AddProduct([FromBody] ProductCreateDto productCreateDto)
        {
            
            var result = await _productService.AddAsync(productCreateDto);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

    }
}
