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

            Weapon gun = new Weapon("Gun", 4338724); // Makes a new gun with 4338724 ammo slots and names it Gun (dont increase or ram go bye bye)
            gun.ammolist[4].ModifyBySpeedAndDirection(); // Modifies the projectile location using the direction and speed

            // Another gun to test how gun firing works
            Weapon testGun = new Weapon("Gun", 2);
            testGun.useWeapon();
            testGun.useWeapon();
            testGun.useWeapon();


            Console.ReadKey(true);
        }
    }
}