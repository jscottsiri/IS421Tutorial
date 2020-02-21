using System;
using System.Collections.Generic;
using System.Text;

namespace IS421Tutorial
{
    class Class3 : Class1
    {
        public override void Superpower()
        {
            Console.WriteLine("She can't die!");
            Eternal();
            Console.WriteLine("She will live as the world ends!");
        }

        private void Eternal()
        {
            if (health <= 0)
            {
                health = 1;
            }
        }
    }
}
