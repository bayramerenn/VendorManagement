using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.VendorManagement
{
    public class ProductAttribute:BaseColumns,IEntity
    {
        public int Id { get; set; }
        public byte AttributeTypeCode { get; set; }
        public string AttributeCode { get; set; }
    }
}
