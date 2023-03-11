namespace _4
{
    internal class Photographer
    {
        delegate void PublicPhoto(Photographer photographer);
        event PublicPhoto? pb;

        private string _name;

        public string Name { get => _name; }

        public Photographer(string name)
        {
            _name = name;
        }

        public void Attach(IObserver observer)
        {
            pb += observer.Update;
            observer.Subscribing(this);
        }

        public void Detach(IObserver observer)
        {
            pb -= observer.Update;
            observer.Unsubscribing(this);
        }
        public void Pub(bool tr)
        {
            if (tr == true)
                Console.WriteLine($"Photographer {_name} post a photo ");
            else
                Console.WriteLine("Photographer unpost a photo");
        }

    }
}
