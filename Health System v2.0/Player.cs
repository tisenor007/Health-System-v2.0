using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v2._0
{
    class Player
    {
        //fields
        static int lives;
        static int health;
        static int shield;
        

        //methods
        //public void init()
        public Player()
        {
            lives = 3;
            health = 100;
            shield = 100;
        }
        public void TakeDamage(int damage)
        {
            Console.WriteLine("Player about to take: " + damage + " damage");
            int remainingDamage;
            //spill over effect
            remainingDamage = damage - shield;
            shield = shield - damage;

            if (shield <= 0){

                shield = 0;
                health = health - remainingDamage;
            }

            if(health <= 0)
            {
                lives = lives - 1;
                Console.WriteLine("Player has died.");
                
                health = health + 100;
                shield = shield + 100;
            }

        }
        public void Heal(int hp)
        {
            Console.WriteLine("Player is about to heal " + hp +" health points");
            health = health + hp;
        }
        public void ShieldRegen(int sp)
        {
            Console.WriteLine("Player is about to heal " + sp + " shield points");
            shield = shield + sp; 
        }
        public void ShowStats()
        {
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine();
        }

    }
}
