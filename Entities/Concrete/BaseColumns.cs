using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class BaseColumns
    {
        public byte ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public string CreatedUserName { get; set; }
        public string LastUpdatedUserName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime LastUpdatedDate { get; set; } = DateTime.Now;
    }
}
