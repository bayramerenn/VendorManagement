using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.VendorManagement
{
    public class ProductVariant:BaseColumns,IEntity
    {
        public int Id { get; set; }
        public string ColorCode { get; set; }
        public string ItemDim1Code { get; set; }
       
    }
}
