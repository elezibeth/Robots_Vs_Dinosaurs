﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVDino
{
    class Weapon
    {
        //members
        
        public string type;
        public int attackPower;

        //constructor
        public Weapon(string type, int attackPower)
        {
            this.type = type;
            this.attackPower = attackPower;

            
        }

        //method
        public void UseWeaponToAttack()
        {
            Console.WriteLine("20 mm rounds dispensed in 5 second bursts. Deals -25 damage to health of Dinsoaur.");
        }
        
    }
}
