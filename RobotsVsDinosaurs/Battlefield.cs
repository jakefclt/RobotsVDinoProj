using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Battlefield 
    {
        //member variable (Has A)
        Fleet robotFleet = new Fleet();
        Herd dinoHerd = new Herd();

        Herd spinosaurusBattle = new Herd();
        
        //constructor
        public Battlefield()
        {
            
        }

       
        //member method(Can Do)  
        
       
    public void RunBattle()
        {
            robotFleet.Robots[0].attack(Dino);
            
            dinoHerd.ChooseDinosaur();
            robotFleet.ChooseRobot();

            Console.WriteLine("Prepare for battle!");
            Console.ReadLine();

            spinosaurusBattle.SpinosaurusAttack();
            
            Console.ReadLine();

            

           
        }
    }
}
