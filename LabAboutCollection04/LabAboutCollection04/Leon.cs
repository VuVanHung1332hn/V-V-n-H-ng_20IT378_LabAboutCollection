using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAboutCollection04
{
    internal class Leon : StartUp
    {
        public Leon()
        {
          
        }

        // Override the sleep and eats methods from the animal class
        public override void model()
        {
            Console.WriteLine("Grey Seat Leon");
        }
        //public override void color()
        //{
         //   Console.WriteLine("Grey Leon");
        //}
        public override void Start()
        {
            Console.WriteLine("Engine start");
        }
        public override void Stop()
        {
            Console.WriteLine("Breaaak!");
        }
    }
}
