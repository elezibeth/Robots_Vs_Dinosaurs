using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVDino
{
    class Fleet
    {
        public List<Robot> fleet;
        public Robot ted;
        public Robot fred;
        public Robot bill;
        public bool lifeStatus;


        public Fleet()
        {
            fleet = new List<Robot>();
            ted = new Robot("Ted", 100, 100);
            fred = new Robot("Fred", 100, 100);
            bill = new Robot("Bill", 100, 100);
            AddRobotsToFleet();



        }
        public void AddRobotsToFleet()
        {
            fleet.Add(ted);
            fleet.Add(fred);
            fleet.Add(bill);
        }

        public void KillRobot(Robot robot)
        {
            //if robot lifeStatus == false: remove robot from list;
            if (lifeStatus == false)
            {
                fleet.Remove(robot);
                Console.WriteLine(robot.name + " has run out of energy or has been destroyed and can no longer play.");
            }
            
        }
        public void FleetTurn()
            //-- run attack
        {
            //writeline
            //display available robots in list
            //choose robot from list via 1,2, or 3, press enter
            //switch case (choose robot)
            //choose available dinosaur to attack with herd attributes method
            //switch case (choose dinosaur to attack with switch case)
            //attack chosen dinosaur on dinosaur
            
            //run check life status of chosen robot
            //run kill robot
            
            //run get attacked by robots on dinosaur method
            //run check dinosaur life status
            //run kill dinosaur
        }

        public void TakeHit()
        {
           
            if(fleet.Count >= 0)
            {
                DisplayRobotName();
                fleet[0].GetAttackedByDinosaur();
                DisableRobot();
            }
            else
            {
                Console.WriteLine("Robots are out. Attacking is senseless.");
            }


           
        }
        public void DisplayRobotName()
        {
            if (fleet.Count >= 1)
            {
                Console.WriteLine(fleet[0].name);
            }
            else
            {
                Console.WriteLine("Robots have no capacity to fight anymore.");
            }


        }   
            
        
        public void DisableRobot()
        {
            if(bill.percentageHealth == 0)
            {
                fleet.Remove(bill);
                Console.WriteLine("Bill is now scrap metal.");
            }
            if (ted.percentageHealth == 0)
            {
                fleet.Remove(ted);
                Console.WriteLine("Ted is now scrap metal.");
            }
            if (fred.percentageHealth == 0)
            {
                fleet.Remove(fred);
                Console.WriteLine("Fred is now scrap metal.");
            }
        }
        
            
        
        
        

    }
}
