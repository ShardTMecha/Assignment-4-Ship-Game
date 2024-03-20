using Raylib_cs;
using System.Numerics;

namespace Ship_Game
{
    internal class Asteroids
    {
        static string title = "Ship Game";

        static Random rng = new Random();

        //General values
        Vector2 asteroidVelocity;
        Vector2 initialPosition;
        Color color;

        //Big asteroid values
        Vector2 asteroidPosition1;
        int asteroidRadius1;
        int bigAsteroidAmount;

        //Small asteroid values
        Vector2 asteroidPosition2;
        int asteroidRadius2;
        int smallAsteroidAmount;

        static void Main(string[] args)
        {
            Raylib.InitWindow(1620, 1080, title);
            Raylib.SetTargetFPS(60);

            Setup();

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.RayWhite);

                Update();

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
        static void Setup()
        {

        }
        static void Update()
        {

        }
        //Random position generator
        public void Random()
        {
            //Random Y for big asteroids
            asteroidPosition1 = new Vector2(800, (rng.Next(Raylib.GetScreenWidth(), Raylib.GetScreenHeight()) * 50));
            //Random Y for small asteroids
            asteroidPosition2 = new Vector2(800, (rng.Next(Raylib.GetScreenWidth(), Raylib.GetScreenHeight()) * 50));
        }

        //Check collision between player and asteroids       
        public void Collision()
        {

        }
        public void DrawAsteroids()
        {
            //Big asteroid Drawing
            Raylib.DrawCircleV(asteroidPosition1, asteroidRadius1, color);

            //Small asteroid Drawing
            Raylib.DrawCircleV(asteroidPosition1, asteroidRadius1, color);
        }

    }
}
