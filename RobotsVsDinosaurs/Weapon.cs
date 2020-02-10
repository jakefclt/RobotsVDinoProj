using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Weapon
    {
        //member variable(Has A)
        public string masterBlaster;
        public double masterBlasterAttackPower;

        //constructor
        public Weapon()
        {
            
        }
        //member method(Can Do)
        public void MegaManWeapon()
        {
            masterBlaster = "Master Blaster";
            masterBlasterAttackPower = 10;
        }
       
    }
}
