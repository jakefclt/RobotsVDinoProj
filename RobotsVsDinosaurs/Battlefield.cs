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
        public Herd herd = new Herd();
        public Fleet fleet = new Fleet();
       
        
        //constructor
        public Battlefield()
        {
            
        }

       
        //member method(Can Do)  
        
       
    public void RunBattle()
        {
            while (herd.DinoHerd[0].health > 0 || herd.DinoHerd[1].health > 0 || herd.DinoHerd[2].health > 0 ||
               fleet.RobotFleet[0].health >0 || fleet.RobotFleet[1].health > 0 || fleet.RobotFleet[2].health >0)
            {
                Console.WriteLine("Choose your dinosaur for battle.");
                int j = 1;
                foreach(Dinosaur dino in herd.DinoHerd)
                {
                    Console.WriteLine($"{j}. {dino.type}");
                    j++;
                }
                Dinosaur attackingDino = herd.ChooseDinosaur();

                Console.WriteLine("Choose Robot to attack.");
                int l = 1;
                foreach (Robot robo in fleet.RobotFleet)
                {
                    Console.WriteLine($"{l}. {robo.name}");
                    l++;
                }

                Robot robotAttacked = fleet.ChooseRobot();
                attackingDino.DinoAttack(robotAttacked);
                Console.WriteLine("Press enter to play next round");
                Console.ReadLine();                
                Console.WriteLine("Choose your robot for battle.");
                int k = 1;
                foreach (Robot robo in fleet.RobotFleet)
                {
                    Console.WriteLine($"{k}. {robo.name}");
                    k++;
                }

                Robot attackingRobot = fleet.ChooseRobot();
                Console.WriteLine("Choose dinosaur to attack.");
                int m = 1;
                foreach (Dinosaur dino in herd.DinoHerd)
                {
                    Console.WriteLine($"{m}. {dino.type}");
                    m++;
                }

                Dinosaur dinoAttacked = herd.ChooseDinosaur();
                attackingRobot.RobotAttack(dinoAttacked);
                Console.WriteLine("Press enter to play next round");
                Console.ReadLine();

                for (int i = 0; i < herd.DinoHerd.Count; i++)
                {
                    
                    if (herd.DinoHerd[i].health <= 0)
                    {
                        herd.DinoHerd.RemoveAt(i);

                    }
                }
                if (herd.DinoHerd.Count == 0)
                {

                    Console.WriteLine("Robot Fleet Has Won The Battle!");
                }

                for (int i = 0; i < fleet.RobotFleet.Count; i++)
                {
                    if (fleet.RobotFleet[i].health <= 0)
                    {
                        fleet.RobotFleet.RemoveAt(i);
                    }

                }

                if (fleet.RobotFleet.Count == 0)
                {
                    Console.WriteLine("Dinosaur Herd Has Won The Battle!");
                }

            }


          
            
               
           
           






        }
    }
}
