using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.VendorManagement
{
    public class ProductColorFabricBlend : BaseColumns, IEntity
    {
        public int Id { get; set; }
        public string ColorCode { get; set; }
        public string ProductPartCode { get; set; }
        public string FabricCode { get; set; }
        public Single BlendPercentage { get; set; }
        
    }
}
