using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_Unity
{
    public class Cat : IAnimal, IHaveName
    {
        public Cat(string name)
        {
            this.Name = name;
        }

        public void Shout()
        {
            Console.WriteLine(Name + ": Miao~Miao~");
        }

        public string Name { get; set; }
    }
}