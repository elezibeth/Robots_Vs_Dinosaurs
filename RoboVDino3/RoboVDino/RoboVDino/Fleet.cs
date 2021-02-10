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
        public string robotChoice;

        //constructor
        public Fleet()
        {
            fleet = new List<Robot>();
            ted = new Robot("Ted", 100, 100);
            fred = new Robot("Fred", 100, 100);
            bill = new Robot("Bill", 100, 100);
            AddRobotsToFleet();



        }
        //methods
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
        public void FleetTurn()//////////////////////////////////////////////////////////////////////////////
            
        {
            
            DisplayRobotsInList();
            ChooseRobotFromList();////////////////////
            // returns string robotChoice
            ChooseRobot(); //use string robotChoice for switch case
            DisableRobot();
            
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

        public void DisplayRobotsInList()
        {
            if (fleet.Count() == 3)
            {

                Console.WriteLine($"The robots available to your are 1. Ted, 2. Fred, and 3. Bill. Please type '1', '2', or '3' and press enter.");
            }
            if (fleet.Count() == 2)
            {
                Console.WriteLine("You've got two dinosaurs left. Just pick '1' or '2' and let's get on with it.");
            }
            if (fleet.Count() == 1)
            {
                Console.WriteLine("No one gets out alive. Select '1'.");
            }
        }
        public void ChooseRobotFromList()
        {
            robotChoice = Console.ReadLine();

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



        public void TakeHit()
        {

            if (fleet.Count >= 0)
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

        public void DisableRobot()
        {
            if (bill.CheckLifeStatus() == false)
            {
                fleet.Remove(bill);
                Console.WriteLine("Bill is now scrap metal.");
            }
            if (ted.CheckLifeStatus() == false)
            {
                fleet.Remove(ted);
                Console.WriteLine("Ted is now scrap metal.");
            }
            if (fred.CheckLifeStatus() == false)
            {
                fleet.Remove(fred);
                Console.WriteLine("Fred is now scrap metal.");
            }

        }

        public void ChooseRobot()
        {
            switch (robotChoice)
            {
                case "1":
                    Console.WriteLine("Robot Ted will attack!");
                    
                    if (ted.CheckLifeStatus() == true)/////////////////////////////////////////////////////////////
                    {
                        ted.AttackDinosaur();
                    }


                    break;
                case "2":
                    Console.WriteLine("Robot Fred will attack!");
                    
                    // fred attacks dinosaur

                    if (fred.CheckLifeStatus() == true)
                    {
                        fred.AttackDinosaur();
                    }

                    break;
                case "3":
                    Console.WriteLine("Checking if Bill can attack!");
                    
                    bool alive = bill.CheckLifeStatus();
                    if (alive == true)
                    {
                        bill.AttackDinosaur();
                    }

                    break;
                default:
                    Console.WriteLine("invalid choice. A Robot will be selected unless it breaks the program. Please don't do that again. ");
                    if (bill.CheckLifeStatus() == true)
                    {
                        bill.AttackDinosaur();
                    }
                    if (ted.CheckLifeStatus() == true)
                    {
                        ted.AttackDinosaur();
                    }
                    if (fred.CheckLifeStatus()== true)
                    {
                        fred.AttackDinosaur();
                    }
                    else
                    {
                        Console.WriteLine("Robots have no more moves. You have lost.");

                    }
                    

                    break;

            }
          


           
        
          
                



        }

        

        
            
        
        
        
           
     }
        
            
        
        
        

}

