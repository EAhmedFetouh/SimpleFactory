
namespace SimpleFactory
{
    public class Ship : ITransport
    {
        public void Deliver() => Console.WriteLine("[🚢] Delivery Status: Delivered by Ship");
    }

}
