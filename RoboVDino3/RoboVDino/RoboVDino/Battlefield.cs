using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVDino
{
    class Battlefield
    {
        //members
        //fleet,
        //herd
        public Herd herdPlayer1;
        public Fleet fleetPlayer2;
        public bool playerTurn; // playerTurn - true - player1 turn

        //ctor SCENARIO???!!!
        //( instantiate herds, //done
        //fleet, //done
        //attack algorithm) *inprocess
        public Battlefield()
        {
            herdPlayer1 = new Herd();
            fleetPlayer2 = new Fleet();
            DisplayPlayers();
            Battle();
            
           


            
            //herdPlayer1.takeHit();

        }


        //methods

        public void LoopTurns()
        {

        }
        public void DisplayPlayers()
        {
            Console.WriteLine(" Player 1 owns the dinosaur herd, and player 2 owns the robot fleet. Dinosaurs go first");
        }

        public void PlayerOneTurn()
        {
                 herdPlayer1.HerdTurn();
                 fleetPlayer2.TakeHit();
            playerTurn = false;
        }
        public void PlayerTwoTurn()
        {
            fleetPlayer2.FleetTurn();
            herdPlayer1.TakeHit();
            playerTurn = true;
        }
       

        public void Battle()//do while loop.....
        {
            //bool swap turns
            while (fleetPlayer2.fleet.Count() >= 1 && herdPlayer1.dinosaurHerd.Count() >= 1)
            {
                //bool
                if(playerTurn == true && herdPlayer1.dinosaurHerd.Count() >= 1)///////////////////////////////////////////////////////
                {
                    PlayerOneTurn();
                    herdPlayer1.BenchDinosaurs();
                    fleetPlayer2.DisableRobot();
                }
                if(playerTurn == false && fleetPlayer2.fleet.Count() >= 1)
                {
                    PlayerTwoTurn();
                    herdPlayer1.BenchDinosaurs();
                    fleetPlayer2.DisableRobot();

                }
                

            }

            if(fleetPlayer2.fleet.Count == 0 || herdPlayer1.dinosaurHerd.Count == 0)
            {
                EndGame();
            }
        }

        public void EndGame()
        {
            Console.WriteLine("Thank you for playing. Game over.");
        }
        //public void DisplayWinner()//////////////////////////////////////////////fix me///////////////////
        //{
        //    if ()
        //}


        
        //Play - loop take turns attacking (until all 3 robots or dinosaurs are dead)

        

        // check if fleet or herd decimated (display winner and loser)

        //instantiate herd
        //instantiate fleet
        //robots attack dinos
        //dinos attack robots
            
        //end game if all robots dead(removed from list)
        //end game if all dinosaurs dead(removed from dinosaur list)
    }
    
    
}
