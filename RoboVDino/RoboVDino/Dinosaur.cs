using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVDino
{
    class Dinosaur
    {

        //member
        public string type;
        public int health;
        public int energy;
        
        public int attackPower;
        public bool aliveStatus;

        public Dinosaur(string type, int health, int energy, int attackPower)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;
            aliveStatus = true;

            


        }

        //can do methods

        public void GetAttackedByRobot()
        {
            //subtract health from dinosaur
            DepleteHealth();
            // use dinosaur method to display health of disosaur who was attacked
            DisplayHealth();
            //decide whether or not to kill dinosaur
        }

        public void DepleteHealth()
        {
            health -= 25;
            
        }
        public void DisplayHealth()
        {
            Console.WriteLine($"{health} % health remaining");
        }

        public void AttackRobot()
        {
            // robot gets attacked by dino
            //GetAttackedByDinosaur();


            //Dino loses energy
            LoseEnergy();
            //display dino energy
            DisplayEnergy();
            //decide whether or not to run kill dinosaur
            CheckDinosaurLifeStatus();

        }
        public void LoseEnergy()
        {
            energy -= 25;
        }
        public void DisplayEnergy()
        {
            Console.WriteLine($"energy is at {energy}%");
        }

        public bool CheckDinosaurLifeStatus()
        {
            if (energy == 0  || health == 0)
            {
                aliveStatus = false;
                Console.WriteLine("the dinosaur has been decimated  or has run out of energy.");
                return aliveStatus;
            }

            else
            {
                aliveStatus = true;
                return aliveStatus;
            }
            
        }
        

    }
}
