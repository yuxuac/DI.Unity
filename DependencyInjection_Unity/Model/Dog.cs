using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_Unity
{
    public class Dog : IAnimal, IHaveName
    {
        public Dog(string name)
        {
            this.Name = name;
        }

        public void Shout()
        {
            Console.WriteLine(Name + ":Wan~Wan~");
        }

        public string Name { get; set; }
    }
}