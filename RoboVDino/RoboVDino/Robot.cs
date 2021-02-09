using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVDino
{
    class Robot
    {
        //members
        public string name;
        public int percentageHealth;
        public int powerLevel;
        public Weapon twentyMMRounds;
        public bool lifeStatus;

        public Robot(string name, int percentageHealth, int powerLevel)
        {
            this.name = name;
            this.percentageHealth = percentageHealth;
            this.powerLevel = powerLevel;
            twentyMMRounds = new Weapon("20 mm round", 25);
            lifeStatus = true;
        }

        //cando method

        public void AttackDinosaur()
        {
            //subtract health level from dinosaur
            twentyMMRounds.UseWeaponToAttack();
            //display power level of attacking robot with a method
            //subtract power from robot
            SubtractPower();
            DisplayPowerLevel();
            CheckLifeStatus();
            //decide whether or not to kill robot

        }
        public void SubtractPower()
        {
            powerLevel -= 25;
        }
        public void DisplayPowerLevel()
        {
            Console.WriteLine($"{name}'s power level is at {powerLevel}%");
        }
        public void GetAttackedByDinosaur()
        {
            //reduce percentageHealth
            ReducePercentageHealth();
            //display percentageHealth
            DisplayPercentageHealth();
            //decide whether or not to kill robot
        }
        public void ReducePercentageHealth()
        {
            percentageHealth -= 25;
        }
        public void DisplayPercentageHealth()
        {
            Console.WriteLine($"This Robot's health is at {percentageHealth}%");
        }

        public bool CheckLifeStatus()
        {
            if (powerLevel == 0 || percentageHealth == 0)
            {
                lifeStatus = false;
                return lifeStatus;
            }

            else
            {
                lifeStatus = true;
                return lifeStatus;
            }

        }
    }

   



}

    

