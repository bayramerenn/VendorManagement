using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.VendorManagement
{
    public class Product:BaseColumns,IEntity
    {
        public int Id { get; set; }
        public byte ItemDimTypeCode { get; set; }
        public int ProductHierarchyId { get; set; }
        public bool? UseInternet { get; set; }
        public bool? UsePOS { get; set; }
        public bool? UseStore { get; set; }
        public string ItemAccountGrCode { get; set; }
        public string ItemTaxGrCode { get; set; }
        public int? ProductCollectionGrCode { get; set; }
        public byte StorePriceLevelCode { get; set; }
        public byte CommercialRoleCode { get; set; }
        public bool IsFranchising { get; set; }
        public DateTime LastOrderDate { get; set; }
        public bool? IsCompleted { get; set; }

    }
}

