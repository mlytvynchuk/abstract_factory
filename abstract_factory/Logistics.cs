using System;

namespace abstract_factory
{
    public interface ILogistics
    {
        public ITransport createTransport();
        public void start();
    }
    public interface ITransport
    {
        public void go();
    }
    
   
   
    
    public abstract class Logistics
    {
        public void start()
        {
            ITransport transport = createTransport();
            transport.go();
        }

        public abstract ITransport createTransport();
    }

}
