namespace WeddingShop.Web.Common.AutoMapping
{
    public interface IMapperAdapter
    {
        TDestination Map<TDestination>(object source);
    }
}
