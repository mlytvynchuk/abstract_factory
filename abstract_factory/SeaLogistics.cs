using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_factory
{
    public class SeaLogistics : Logistics, ILogistics
    {
        public override ITransport createTransport()
        {
            return new Ship();
        }
    }
}
