using AutoMapper;
using SOM.Core.DBModel;
using SOM.Core.Dto;
using SOM.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SOM.Core.Mapping
{
    public class ElementMapping : Profile
    {
        public ElementMapping()
        {
            CreateMap<ElementDto, Element>().ReverseMap();
            CreateMap<ElementModel, Element>().ReverseMap();
        }
    }
}
