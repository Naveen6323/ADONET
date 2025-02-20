using ObserverDesignPattern;

namespace ObersverDedignPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            User user = new("naveen");
            User user1 = new("sai");
            School sch = new("sri chaitanya");
            School sch1 = new("narayana");
            NewsAgency newsAgency = new();
            newsAgency.RegisterObserver(user);
            newsAgency.RegisterObserver(user1);
            newsAgency.RegisterObserver(sch);
            newsAgency.NotifyObservers("news1");

        } 
    }
    }