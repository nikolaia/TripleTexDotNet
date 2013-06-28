using System.Collections.Generic;
using TripleTexDotNet.Classes;

namespace TripleTexDotNet.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> SearchForProducts(string searchString);
        void SaveProduct();
    }
}