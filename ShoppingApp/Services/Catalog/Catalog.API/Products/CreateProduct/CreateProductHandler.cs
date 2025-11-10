using MediatR;

namespace Catalog.API.Products.CreateProduct
{

    public record CreateProductCommand(string name, List<string> categories, string description, string imageFile, decimal price) 
        : IRequest<CreateProductResult>;
    public record CreateProductResult(Guid Id);
    internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
