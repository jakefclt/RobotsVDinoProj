using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {

        //I want a Robot to have a name, health, power level, and a Weapon with a type 
        //(i.e. sword) and attack power

        //member variable(Has A)
        public string name;
        public int health;
        public double powerLevel;

        //constructor
        public Robot()
        {
            Console.WriteLine("Choose your robot for battle. \n 1. Mega Man 2. Cut Man 3. Guts Man");
            name = Console.ReadLine();
            health = 10;
            powerLevel = 100;
            Weapon main = new Weapon();

        }

        //member method(Can Do)

        public void AttackDinosaur()
        {
            string attack =

        }

    }
}
