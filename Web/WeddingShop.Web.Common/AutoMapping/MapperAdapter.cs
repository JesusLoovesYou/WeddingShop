using AutoMapper;

namespace WeddingShop.Web.Common.AutoMapping
{
    public class MapperAdapter : IMapperAdapter
    {
        public TDestination Map<TDestination>(object source)
        {
            return Mapper.Map<TDestination>(source);
        }
    }
}