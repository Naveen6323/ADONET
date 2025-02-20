using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    class School:IObersver
    {
        private string name;
        public School(string name)
        {
            this.name = name;
        }
        public void Update(string news)
        {
            Console.WriteLine($"School {name} received  news: " + news);
        }
    }
    class User : IObersver
    {
        private string name;
        public User(string name)
        {
            this.name = name;
        }
        public void Update(string news)
        {
            Console.WriteLine($"User {name} received  news: " + news);
        }
    }
}
