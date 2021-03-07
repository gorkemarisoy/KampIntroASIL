using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    class Robot:IWorker     //robot maaş almaz, yemez de ondan tek interface atadık.
    {
        public void Work()
        {
            Console.WriteLine("Robot çalıştım");
        }
    }
}
