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
             
        }


        //member method(Can Do)
        public void ChooseRobot()
        {
            Console.WriteLine("Choose your robot for battle. \n 1. Mega Man 2. Cut Man 3. Guts Man");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":

                    Console.WriteLine("You have chosen Mega Man");
                    Robot megaman = new Robot("Mega man", 3, 3, new Weapon());
                    RobotFleet.Add(megaman);
                    break;

                case "2":

                    Console.WriteLine("You have chosen Cut Man");
                    Robot cutman = new Robot("Cut man", 2, 2, new Weapon());
                    RobotFleet.Add(cutman);
                    break;

                case "3":


                    Console.WriteLine("You have chosen Gut Man");
                    Robot gutman = new Robot("Gut Man", 1, 1, new Weapon());
                    RobotFleet.Add(gutman);
                    break;



            }
        }

    }

}
    



