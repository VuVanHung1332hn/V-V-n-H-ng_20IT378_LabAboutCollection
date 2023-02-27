using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAboutCollection04
{
    internal class Tesla : StartUp
    {
        public Tesla()
        {
         
        }

        // Override the sleep and eats methods from the animal class
        public override void model()
        {
            Console.WriteLine("Red Tesla Model 3 with 2 Batteries");
        }
       // public override void color()
       // {
        //    Console.WriteLine("A Cat sounds 'Meo Meo'");
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
