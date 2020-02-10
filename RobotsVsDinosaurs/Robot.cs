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
        public double defense;
        Weapon mainWeapon = new Weapon();
        //constructor
        public Robot(string name, int attackPower, int defense, Weapon weapon)
        {
            this.name = name;
            this.attackPower = attackPower;
            this.defense = defense;
            mainWeapon = weapon;
            health = 100;
            powerLevel = 100;
            

        }

        //member method(Can Do)
    

       
      

            


        

    }
}
