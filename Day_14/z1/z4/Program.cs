using _4;
Photographer photographer = new Photographer("Valentina Kolmakova");

Subscriber1 subscriber1 = new Subscriber1("Sveta");
Subscriber2 subscriber2 = new Subscriber2("Luda");
photographer.Pub(true);
if (true)
{
    photographer.Attach(subscriber1);
    photographer.Attach(subscriber2);
}
else
{
    photographer.Detach(subscriber1);
    photographer.Detach(subscriber2);
}


