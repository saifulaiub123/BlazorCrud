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
    public class WindowMapping : Profile
    {
        public WindowMapping()
        {
            CreateMap<WindowDto, Window>().ReverseMap();
            CreateMap<WindowModel, Window>().ReverseMap();
        }
    }
}
