using AutoMapper;
using SOM.Core.DBModel;
using SOM.Core.Dto;
using SOM.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOM.Core.Mapping
{
    public class WindowElementMapping : Profile
    {
        public WindowElementMapping()
        {
            CreateMap<WindowElementDto, WindowElement>().ReverseMap();
            CreateMap<WindowElementModel, WindowElement>().ReverseMap();
        }
    }
}
