using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TripleTexDotNet.Classes;

namespace TripleTexDotNet.Services
{
    public class ProductService
    {
        private readonly SyncService _syncService;

        public ProductService(SyncService syncService)
        {
            _syncService = syncService;
        }

        public IEnumerable<Product> SearchForProducts(string searchString)
        {
            return _syncService.GetService().Call<IEnumerable<Product>>("Product.searchForProducts", -1, searchString);
        }

        public void SaveProduct()
        {
            throw new NotImplementedException();
        }
    }
}
