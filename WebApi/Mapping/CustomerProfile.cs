using AutoMapper;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Dtos;

namespace WebApi.Mapping
{
    public class CustomerProfile:Profile
    {
        public CustomerProfile()
        {
            //CreateMap<ProductHierarchy, ProductHierarchyDto>()
            //    .ForMember(dest => dest.Id, member => member.MapFrom(x => x.ProductHierarchyID))
            //    .ForMember(dest => dest.Gender, member => member.MapFrom(x => x.ProductHierarchyLevel01))
            //    .ForMember(dest => dest.MainGroup, member => member.MapFrom(x => x.ProductHierarchyLevel02))
            //    .ForMember(dest => dest.Category, member => member.MapFrom(x => x.ProductHierarchyLevel03));
        }
    }
}
