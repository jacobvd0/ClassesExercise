using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace ClassesExercise // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Projectile projectile = new Projectile(2.0f, new Vector2(0.0f, 0.0f), new Vector2(5.0f, 2.0f));
            projectile.ModifyBySpeedAndDirection();
        }
    }
}