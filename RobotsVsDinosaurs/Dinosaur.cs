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
        
        //constructor
        public Dinosaur(string type, double attackPower)
        {
            this.type = type;
            this.attackPower = attackPower;            
            health = 100;
            energy = 100;
        }

        //member method (Can Do)
       public void DinoAttack(Robot robot)
        {
            robot.health -= attackPower;
            energy -= 10;

            Console.WriteLine("Dinosaurs current energy is at " + energy + " %");
            Console.WriteLine("Robots current health is at " + robot.health + " %");

        }

        

    }   
}
