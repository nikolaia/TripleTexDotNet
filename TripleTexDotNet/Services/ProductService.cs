using System;
using System.Collections.Generic;
using TripleTexDotNet.Classes;
using TripleTexDotNet.Interfaces;

namespace TripleTexDotNet.Services
{
    public class ProductService : IProductService
    {
        private readonly IJsonService _service;

        public ProductService(IJsonService service)
        {
            _service = service;
        }

        public IEnumerable<Product> SearchForProducts(string searchString)
        {
            return _service.Call<IEnumerable<Product>>("Product.searchForProducts", -1, searchString);
        }

        public void SaveProduct()
        {
            throw new NotImplementedException();
        }
    }
}
