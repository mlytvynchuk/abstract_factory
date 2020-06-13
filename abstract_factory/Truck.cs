using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_factory
{
    public class Truck : ITransport
    {
        public void go()
        {
            Console.WriteLine("Truck is going");
        }
    }
}
