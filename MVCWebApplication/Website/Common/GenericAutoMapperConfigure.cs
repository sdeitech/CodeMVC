using AutoMapper;

namespace Website.Common
{
    public class GenericAutoMapperConfigure
    {
        public static Mapper InitializeAutoMapper<TSource, TDestination>()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TSource, TDestination>();
            });

            var mapper = new Mapper(mapperConfig);

            return mapper;
        }
        
    }
}