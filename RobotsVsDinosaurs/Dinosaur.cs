using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Dinosaur
    {
        //member variable(Has A)
        public string type;
        public double health;
        public double energy;
        public double attackPower;
        public double defense;
        //constructor
        public Dinosaur(string type, double attackPower, double defense)
        {
            this.type = type;
            this.attackPower = attackPower;
            this.defense = defense;
            health = 100;
            energy = 100;
        }

        //member method (Can Do)
       public void DinoAttack(Robot robot)
        {
            robot.health -= attackPower;

        }

        

    }   
}
