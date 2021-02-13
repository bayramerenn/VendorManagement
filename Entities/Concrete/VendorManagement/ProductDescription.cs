using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.VendorManagement
{
    public class ProductDescription:BaseColumns,IEntity
    {
        public int Id { get; set; }
        public string ItemDescription { get; set; }
    }
}
