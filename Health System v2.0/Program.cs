using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Health System v2.0......:");
            Console.WriteLine();

            //instantiation of "Player" class
            Player player1; //declaration
            player1 = new Player();//instantiation
            //player1.init();

            player1.ShowStats();
            player1.TakeDamage(125);
            player1.ShowStats();
            player1.Heal(10);
            player1.ShieldRegen(50);
            player1.ShowStats();
            player1.TakeDamage(200);
            player1.ShowStats();

            Console.ReadKey(true);
        }
    }
}
