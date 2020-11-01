using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServerApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        //Add Stuff
        public double AddValues(double valA, double valB)
        {
            return valA + valB;
        }

        //Substract stuff
        public double SubstractValues(double valA, double valB)
        {
            return valA - valB;
        }


        //Multiply stuff
        public double MultiplyValues(double valA, double valB)
        {
            return valA * valB;
        }


        //Divide stuff
        public double DivideValues(double valA, double valB)
        {
            return valA / valB;
        }

    }
}
