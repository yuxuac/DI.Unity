using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_Unity
{
    public class Apartment : IHouse
    {
        public void PartyOn(IPeople people, IAnimal animal)
        {
            people.Say();
            Console.WriteLine((people as IHaveName).Name + " are playing with " + (animal as IHaveName) .Name);
            animal.Shout();
        }
    }
}