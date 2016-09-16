namespace DependencyBreakingExamples.AdaptParameter
{
    public interface IProductCatalog
    {
        Product GetProductById(long productId);
    }
}