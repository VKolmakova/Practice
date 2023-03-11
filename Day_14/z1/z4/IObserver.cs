namespace _4
{
    internal interface IObserver
    {
        void Update(Photographer photographer);
        void Subscribing(Photographer photographer);
        void Unsubscribing(Photographer photographer);
    }
}
