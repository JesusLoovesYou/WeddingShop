using AutoMapper;

namespace WeddingShop.Web.Common.AutoMapping
{
    public interface IHaveCustomMappings
    {
        void CreateMappings(IMapperConfigurationExpression configuration);
    }
}
