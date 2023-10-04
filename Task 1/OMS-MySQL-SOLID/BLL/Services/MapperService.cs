using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    internal class MapperService
    {
        public static IMapper GetMapper<a, b>()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<a, b>());
            var mapper = config.CreateMapper();
            return mapper;
        }
        public static IMapper GetMapper<a, b, c, d>()
        {
            var config = new MapperConfiguration
                (
                    cfg =>
                    {
                        cfg.CreateMap<a, b>();
                        cfg.CreateMap<c, d>();
                    }
                );
            var mapper = config.CreateMapper();
            return mapper;
        }
    }
}
