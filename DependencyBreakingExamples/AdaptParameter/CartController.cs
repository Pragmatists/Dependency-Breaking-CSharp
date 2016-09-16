using System.Collections.Generic;

namespace DependencyBreakingExamples.AdaptParameter
{
    public class CartController
    {
        private readonly IProductCatalog productCatalog;

        private CartController(IProductCatalog productCatalog)
        {
            this.productCatalog = productCatalog;
        }

        public void AddProductToCart(System.Web.HttpRequest req, System.Web.SessionState.HttpSessionState session)
        {
            var productId = long.Parse(req.Params["productId"]);
            var numberOfItems = int.Parse(req.Params["items"]);

            var product = productCatalog.GetProductById(productId);

            var items =  (Dictionary<Product, int>) session["cart"];
            items[product]= numberOfItems;
        }
    }
}