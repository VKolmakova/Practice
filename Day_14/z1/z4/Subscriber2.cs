namespace _4
{
    internal class Subscriber2 : IObserver
    {
        private string _name;

        public Subscriber2(string name)
        {
            _name = name;
        }
        public void Subscribing(Photographer photographer) => Console.WriteLine($"The subscriber {_name} subscribed from the photographer {photographer.Name} ");

        public void Unsubscribing(Photographer photographer) => Console.WriteLine($"The subscriber {_name} unsubscribed from the photographer {photographer.Name}");
        public void Update(Photographer photographer) => Console.WriteLine($"The subscriber {_name} was notified about the publication of a new photo ");

    }
}
