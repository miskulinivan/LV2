using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv2_vjezba
{
    class Die
    {
        private int numberOfSides;
        private Random randomGenerator;
        //2.zadatak
        //Izmijeniti klasu Die tako da joj se preko konstruktora predaje generator pseudo-slučajnih brojeva
        //konstruktor gore
        public Die(int numberOfSides,Random randomGenerator)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = randomGenerator;
        }
        
        public int Roll()
        {
           int rolledNumber = randomGenerator.Next(1, numberOfSides + 1);
            return rolledNumber;
        }
        //Zadatak 3. cu napisati cijeli  pod komentarom da se mogu lakse switchati ovisno o potrebi klase Die
        //treceg zadatka ili prijasnjih

        
        /*
         private int numberOfSides;
         private RandomGenerator random=RandomGenerator.GetInstance();
         
        public Die(int numberOfSides)
        {
        this.numberOfSides=numberOfSides;
        }

        public int  Roll()
        {
        int rolledNumber=random.NextInt(1,numberOfSides);
        return rolledNumber;
        }
    */
    }
}


