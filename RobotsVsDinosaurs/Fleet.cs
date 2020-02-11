using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Fleet
    {
        //member variable(Has A)
      
        public List<Robot> RobotFleet = new List<Robot>();

        //constructor
        public Fleet()
        {
            Robot megaman = new Robot("Mega man", 20, new Weapon("Blaster", 20));
            RobotFleet.Add(megaman);
            Robot cutman = new Robot("Cut man", 15, new Weapon("Cutter" , 15));
            RobotFleet.Add(cutman);
            Robot gutman = new Robot("Gut Man", 10, new Weapon("Gutter" , 10));
            RobotFleet.Add(gutman);

        }


        //member method(Can Do)
        public Robot ChooseRobot()
        {
            
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":

                    Console.WriteLine("You have chosen " + RobotFleet[0].name);
                    return RobotFleet[0];
                  
                case "2":
                    if(RobotFleet.Count > 1)
                    {
                    Console.WriteLine("You have chosen " + RobotFleet[1].name);
                    return RobotFleet[1];
                    }
                    else
                    {
                        goto default;
                    }
                    
                case "3":
                    if(RobotFleet.Count > 2)
                    {
                     Console.WriteLine("You have chosen " + RobotFleet[2].name);
                    return RobotFleet[2];
                    }
                    else
                    {
                        goto default;
                    }

                default:
                    Console.WriteLine("Not a valid robot");
                    return ChooseRobot();                    


            }
        }

    }

}
    



