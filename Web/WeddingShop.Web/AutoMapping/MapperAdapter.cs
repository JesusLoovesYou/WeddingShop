using AutoMapper;

namespace WeddingShop.Web.AutoMapping
{
    public class MapperAdapter : IMapperAdapter
    {
        public TDestination Map<TDestination>(object source)
        {
            return Mapper.Map<TDestination>(source);
        }
    }
}