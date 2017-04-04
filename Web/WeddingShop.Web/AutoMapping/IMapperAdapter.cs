namespace WeddingShop.Web.AutoMapping
{
    public interface IMapperAdapter
    {
        TDestination Map<TDestination>(object source);
    }
}
