using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_factory
{
    class Program
    {
      public static void Main(string[] args)
        {
            string logistic_type = "road";
            ILogistics logistics;
            if (logistic_type == "sea")
            {
                logistics = new SeaLogistics();
            }
            else if (logistic_type == "road")
            {
                logistics = new RoadLogistics();
            }
            else
            {
                logistics = null;
            }
           
           if (logistics == null)
            {
                Console.WriteLine("Logistic type is not valid");
            }
            else
            {
                logistics.start();
            }

        }
    }
}
