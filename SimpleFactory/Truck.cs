
namespace SimpleFactory
{
    public class Truck : ITransport
    {
        public void Deliver() => Console.WriteLine("[🚚] Delivery Status: Delivered by Truck");
    }

}
