using AutoMapper;

namespace WeddingShop.Web.AutoMapping
{
    public interface IHaveCustomMappings
    {
        void CreateMappings(IMapperConfigurationExpression configuration);
    }
}
