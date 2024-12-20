using Grpc.Core;

namespace GrpcService
{
    public class MyProductService : ProductService.ProductServiceBase
    {
        public override Task<ProductResponse> GetProductDetails(ProductRequest request, ServerCallContext context)
        {
            return Task.FromResult(new ProductResponse
            {
                ProductDetails = $"Details for Product ID: {request.ProductId}"
            });
        }
    }
}