﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dtos
{
    public class ProductHierarchyDto
    {
        public int Id { get; set; }
        public string Gender{ get; set; }
        public string MainGroup{ get; set; }
        public string Category{ get; set; }
    }
}
