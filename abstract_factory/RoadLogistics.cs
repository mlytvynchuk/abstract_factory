using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_factory
{
    public class RoadLogistics : Logistics, ILogistics
    {
        public override ITransport createTransport()
        {
            return new Truck();
        }
    }
}
