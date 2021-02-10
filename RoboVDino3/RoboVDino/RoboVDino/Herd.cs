using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVDino
{
    class Herd
    {

        public List<Dinosaur> dinosaurHerd;
        public Dinosaur liz;
        public Dinosaur jen;
        public Dinosaur fox;
        public string dinoChoice;
        public Dinosaur chosenDinosaur;
        

        public Herd()
        {
            dinosaurHerd = new List<Dinosaur>();
            liz = new Dinosaur("Liz", "Pteredactle", 100, 100, 25);
            jen = new Dinosaur("Jen", "T-Rex", 100, 100, 25);
            fox = new Dinosaur("Fox", "Brontosaurus", 100, 100, 25);
            AddDinosToList();

        }

        //add dinos to list
        public void AddDinosToList()
        {
            dinosaurHerd.Add(liz);
            dinosaurHerd.Add(jen);
            dinosaurHerd.Add(fox);

        }


        //methods
        public void TakeHit()
        {

            if (dinosaurHerd.Count >= 0)
            {
                DisplayDinosaurName();
                dinosaurHerd[0].GetAttackedByRobot();//////////////////////////////////////////////
                BenchDinosaurs();
            }
            else
            {
                Console.WriteLine("Robots are out. Attacking is senseless.");
            }



        }
        public void DisplayDinosaurName()
        {
            if (dinosaurHerd.Count >= 1)
            {
                Console.WriteLine(dinosaurHerd[0].name + "Will be attacked" );
            }
            else
            {
                Console.WriteLine("Dinosaurs have no capacity to fight anymore.");
            }


        }
        public void KillDinosaur(Dinosaur dinosaur)
        {
            
            if (dinosaur.aliveStatus == false)
            {
              
                RemoveDinosaurFromList(dinosaur);
                Console.WriteLine($"{dinosaur} has died");
            }
        }
        public void RemoveDinosaurFromList(Dinosaur dinosaur)
        {
            dinosaurHerd.Remove(dinosaur);
        }
        public void HerdTurn()
        {
            //writeline

            //display available dinos in herd list
            DisplayDinosInList();
            //choose robots from list 1/2/3
            ChooseDinoFromList();

            //switch case dinosaur chosen
            ChooseDino(dinoChoice);


            //if selected dinosaur is dead, run choose dino again., 
            BenchDinosaurs();
            
            
            

            //choose available robot from list
            //switch case attack chosen robot
            //
            //run check life status of dinosaur
            //run kill dino

            //run get attacked by dinosaurs on chosen robot
            //run check robot life status
            

        }
        public void DisplayDinosInList()
        {
            if(dinosaurHerd.Count == 3)
            {

                Console.WriteLine($"The dinosaurs available to your are 1. Liz, 2. Jen, and 3. Fox. Please type '1', '2', or '3' and press enter.");
            }
            if(dinosaurHerd.Count == 2)
            {
                Console.WriteLine("You've got two dinosaurs left. Just pick '1' or '2' and let's get on with it.");
            }
            if(dinosaurHerd.Count == 1)
            {
                Console.WriteLine("No one gets out alive. Select '1'.");
            }
           
                
               
        }
        public void ChooseDinoFromList()
        {
            dinoChoice = Console.ReadLine();
            
        }

        public void ChooseDino(string dinoChoice)
        {
            switch (dinoChoice)
            {
                case "1":
                    Console.WriteLine("Dino Liz will attack!");
                    chosenDinosaur = liz;
                    if (liz.CheckDinosaurLifeStatus() == true)
                    {
                        liz.AttackRobot();
                    }
                    
                    
                    break;
                case "2":
                    Console.WriteLine("Dino Jen will attack!");
                    chosenDinosaur = jen;
                    // jen attacks robot
                    
                    if (jen.CheckDinosaurLifeStatus() == true)
                    {
                        jen.AttackRobot();
                    }
                    
                    break;
                case "3":
                    Console.WriteLine("Checking if Fox can attack!");
                    chosenDinosaur = fox;
                    bool alive = fox.CheckDinosaurLifeStatus();
                    if (alive == true)
                    {
                        fox.AttackRobot();
                    }
                  
                    break;
                default:
                    Console.WriteLine("invalid choice. Fox will be selected unless it breaks the program. Please don't do that again. ");
                    if (fox.CheckDinosaurLifeStatus() == true)
                    {
                        fox.AttackRobot();
                    }
                    if (jen.CheckDinosaurLifeStatus() == true)
                    {
                        jen.AttackRobot();
                    }
                    else
                    {
                        Console.WriteLine("Dinosaurs have no more moves. You have lost.");

                    }
                    //fox attacks robot
                    
                    break;
                    
            }


           
           

        }
        public void BenchDinosaurs()
        {
            if (liz.CheckDinosaurLifeStatus() == false)
            {
                dinosaurHerd.Remove(liz);
                Console.WriteLine("Dinosaur Liz has been benched and cannot help you.");
            }
            if (fox.CheckDinosaurLifeStatus() == false)
            {
                dinosaurHerd.Remove(liz);
                Console.WriteLine("Dinosaur Fox has been benched and cannot help you.");
            }
            if (jen.CheckDinosaurLifeStatus() == false)
            {
                dinosaurHerd.Remove(liz);
                Console.WriteLine("Dinosaur Jen has been benched and cannot help you.");
            }
            else
            {
                Console.WriteLine("Party on, some or all of your dinosaurs are still in the game.");
            }

        }

        


    }
}
