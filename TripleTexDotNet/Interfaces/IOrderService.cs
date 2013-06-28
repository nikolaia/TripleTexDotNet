using TripleTexDotNet.Classes;

namespace TripleTexDotNet.Interfaces
{
    public interface IOrderService
    {
        Order ImportOrdersTripletexCsv(Order order);
    }
}