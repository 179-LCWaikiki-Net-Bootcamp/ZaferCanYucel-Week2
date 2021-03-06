using AutoMapper;
using Entities.Concrete;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class ProductAddProfile : Profile
    {
        public ProductAddProfile()
        {
            CreateMap<ProductAddDto, Product>().ForMember(d => d.Name, operation => operation.MapFrom(source => source.Name)).
                ForMember(d => d.UnitPrice, operation => operation.MapFrom(source => source.UnitPrice)).
                ForMember(d => d.CategoryId, operation => operation.MapFrom(source => source.CategoryId)).
                ForMember(d => d.UnitsInStock, operation => operation.MapFrom(source => source.UnitsInStock)).
                ForMember(d => d.Description, operation => operation.MapFrom(source => source.Description));
        }
    }
}
