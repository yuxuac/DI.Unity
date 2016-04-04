using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_Unity
{
    public class Kid : IPeople, IHaveName
    {
        public Kid(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void Say()
        {
            Console.WriteLine("Hello, I am a kid, my name is:" + this.Name);
        }
    }
}