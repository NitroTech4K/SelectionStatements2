using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatements2
{
    internal class Program
    {


        static string weapon;
        static int health;
        static string healthstatus;

        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals:");
            Console.WriteLine();

            ShowHUD();
            health = 100;

            Console.ReadKey();
        }

        static void weaponWheel(int weaponInt)
        {
            if (weaponInt == 1)
            {
                weapon = "Bolt Pistol";
            }

            else if (weaponInt == 2)
            {
                weapon = "Combat shotgun";
            }

            else if (weaponInt == 3)
            {
                weapon = "Assault Riffle";
            }

            else if (weaponInt == 4)
            {
                weapon = "SMG";
            }

            else if (weaponInt == 5)
            {
                weapon = "Sniper Riffle";
            }

            else if (weaponInt == 6)
            {
                weapon = "Heavy Machine Gun";
            }

            else if (weaponInt == 7)
            {
                weapon = "Grenade Launcher";
            }


            else if (weaponInt == 8)
            {
                weapon = "Ether Collider";
            }
        }
        static void TakeDamage(int damage)
        {
            health = health - damage;
        }

        static void enemiePinkyAttack()
        {
            TakeDamage(30);
        }

        static void ShowHUD()
        {
            Console.WriteLine("Stats");
            Console.WriteLine("-----");

            healthStatusCheck();

            Console.WriteLine("Health: " + health);
            Console.WriteLine("");
            Console.WriteLine("Status: " + healthstatus);
            Console.WriteLine("");
            Console.WriteLine("Weapon: " + weapon);

        }

        static void healthStatusCheck()
        {
            if (health == 100)
            {
                healthstatus = "Full Health";
            }

            else if (health >= 75 && health <= 100)
            {
                healthstatus = "Healthy";
            }
            
            else if (health >= 50 && health <= 74)
            {
                healthstatus = "Okay";
            }
            
            else if (health >= 25 && health <= 49)
            {
                healthstatus = "Hurt";
            }
            
            else if (health >= 10 && health <= 24)
            {
                healthstatus = "Danger!";
            }
            
            else if (health >= 1 && health <= 9)
            {
                healthstatus = "CRITICAL!!!";
            }
        }

    }
}
