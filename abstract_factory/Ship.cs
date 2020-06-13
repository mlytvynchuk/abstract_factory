using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_factory
{
    public class Ship : ITransport
    {
        public void go()
        {
            Console.WriteLine("Ship is swimming");
        }
    }
}
