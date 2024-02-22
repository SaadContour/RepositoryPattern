using Assignment.Models;
using AssignmentEF.ViewModel;
using AutoMapper;

namespace AssignmentEF
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(
                config => {
                    config.CreateMap<Product, ProductViewModel>().ReverseMap();
                });
            return mappingConfig;
        }
    }
}
