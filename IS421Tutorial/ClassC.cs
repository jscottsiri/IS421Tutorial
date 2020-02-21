using System;
using System.Collections.Generic;
using System.Text;
namespace IS421Tutorial
{
    class ClassC
    {
        public void STARTROAR()
        {
            Console.WriteLine("Do the Roar!");
            ClassB BadRoar = new ClassB();
            BadRoar.rawr();
            BadRoar.powerdown(2);
        }
    }
}
