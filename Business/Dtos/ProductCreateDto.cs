using Core.Entities;
using Entities.Concrete.VendorManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Dtos
{
    public class ProductCreateDto:IDtos
    {
        public Product Product { get; set; }
        public ProductDescription ProductDescription{ get; set; }
        public List<ProductAttribute> ProductAttributes { get; set; }
        public List<ProductVariant> ProductVariants{ get; set; }
        public List<ProductColorFabricBlend> ProductColorFabricBlends{ get; set; }
    }
}
