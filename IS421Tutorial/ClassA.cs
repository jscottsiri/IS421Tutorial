using System;

namespace IS421Tutorial
{
    class ClassA
    {
        int classpower;
        
        public void poweron()
        {
            classpower = 5;
        }
        public int powerup(int power)
        {
            return classpower + power;
        }
        public int powerdown(int power)
        {
            return classpower - power;
        }
        private void poweroff()
        {
            classpower = 0;
        }

    }
}
