

namespace SimpleFactory
{
    public static class TransportFactory
    {
        public static ITransport CreateTransportFactory(string type)
        {
            return type switch
            {
                "Truck" => new Truck(),
                "Ship" => new Ship(),
                "Airplane" => new AirPlane(),
                _ => throw new ArgumentException("unkown transport type")
            };
        }
    }
}
