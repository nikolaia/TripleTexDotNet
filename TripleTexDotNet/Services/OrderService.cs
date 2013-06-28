using TripleTexDotNet.Classes;
using TripleTexDotNet.Interfaces;

namespace TripleTexDotNet.Services
{
    public class OrderService : IOrderService
    {
        private readonly IJsonService _service;

        public OrderService(IJsonService service)
        {
            _service = service;
        }

        public Order ImportOrdersTripletexCsv(Order order)
        {
            return _service.Call<Order>("Project.importOrdersTripletexCSV", Helpers.ObjectToCsvString(order), "UTF-8", false, false, true);
        }
    }
}
