using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv2_vjezba
{
    class RandomGenerator
    {
        private static RandomGenerator instance;
        private Random random;

        private RandomGenerator()
        {
            this.random = new Random();
        }
        public static RandomGenerator GetInstance()
        {
            if (instance == null)
                instance = new RandomGenerator();

            return instance;
        }
        public int NextInt(int lowerBound,int upperBound)
        {
            return random.Next(lowerBound, upperBound);
        }
    }
}
//Singleton koji predstavlja generator pseudo-slučajnih brojeva...