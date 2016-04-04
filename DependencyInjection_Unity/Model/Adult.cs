using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_Unity
{
    public class Adult : IPeople, IHaveName
    {
        public string Name { get; set; }

        public void Say()
        {
            Console.WriteLine("Hello, I am an adult, my name is:" + this.Name);
        }
    }
}