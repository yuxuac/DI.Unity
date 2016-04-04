using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_Unity
{
    class Program
    {
        static void Main(string[] args)
        {
            // Without DI, here, we use specific classes.
            IAnimal animal = new Cat("Tom");
            IPeople people = new Kid("Peter");
            IHouse house = new Apartment();
            house.PartyOn(people, animal);

            // With DI, there is no specific class.
            IUnityContainer container = new UnityContainer();
            UnityConfigurationSection configuration = 
                ConfigurationManager.GetSection(UnityConfigurationSection.SectionName) as UnityConfigurationSection;
            configuration.Configure(container, "anyNameYouLike");

            var aHouse = container.Resolve<IHouse>();
            var aPeople = container.Resolve<IPeople>(new ParameterOverride("name", "Peter"));
            var anAnimal = container.Resolve<IAnimal>(new ParameterOverride("name", "Tom"));
            aHouse.PartyOn(aPeople, anAnimal);

            Console.ReadLine();
        }
    }
}