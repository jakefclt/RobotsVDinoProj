using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Robot
    {

        //I want a Robot to have a name, health, power level, and a Weapon with a type 
        //(i.e. sword) and attack power

        //member variable(Has A)
        public string name;
        public double health;
        public double powerLevel;
        public double attackPower;        
        public List<Weapon> Weapon = new List<Weapon>();

        //constructor
        public Robot(string name, int attackPower, Weapon weapon)
        {
            this.name = name;
            this.attackPower = attackPower;                        
            health = 100;
            powerLevel = 100;

            Weapon blaster = new Weapon("Blaster", 10);
            Weapon.Add(blaster);

            Weapon cutter = new Weapon("Cutter", 5);
            Weapon.Add(cutter);

            Weapon gutter = new Weapon("Gutter", 5);
            Weapon.Add(gutter);
        }

       

        //member method(Can Do)
        public void RobotAttack(Dinosaur dinosaur)
        {
            dinosaur.health -= attackPower;
            powerLevel -= 10;
            Console.WriteLine("Robots current power level is at " + powerLevel + " %");
            Console.WriteLine("Dinosaurs current health is at " + dinosaur.health + " %");
        }
    

       
      

            


        

    }
}
