using System;
using System.Numerics;

namespace ClassesExercise // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Projectile projectile = new Projectile(2.0f, new Vector2(0.0f, 0.0f), new Vector2(5.0f, 2.0f)); // Makes a new projectile
            projectile.ModifyBySpeedAndDirection(); // Modifies the projectile location using the direction and speed

            Weapon gun = new Weapon("Gun", 994338724); // Makes a new gun with 4338724 ammo slots and names it Gun
            gun.ammolist[4].ModifyBySpeedAndDirection(); // Modifies the projectile location using the direction and speed

            Console.ReadKey(true);
        }
    }
}