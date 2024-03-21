using Raylib_cs;
using System.Numerics;
internal class Asteroids
{  
    static Random rng = new Random();

    //General values
    Vector2 asteroidVelocity;
    Vector2 initialPosition;
    Color color = Color.Black;

    //Big asteroid values
    Vector2 asteroidPosition1;
    int asteroidRadius1 = 25;
    int bigAsteroidAmount;

    //Small asteroid values
    Vector2 asteroidPosition2;
    int asteroidRadius2 = 15;
    int smallAsteroidAmount;
   
    ////Random position generator
    //public void Random()
    //{
        
        
    //}

    //Check collision between player and asteroids       
   
    public void DrawAsteroids()
    {
        asteroidRadius1 = 25;
        asteroidRadius2 = 15;
        //Random Y for big asteroids
        asteroidPosition1 = new Vector2(800, (rng.Next(Raylib.GetScreenHeight(), Raylib.GetScreenWidth()) * 50));
        //Random Y for small asteroids
        asteroidPosition2 = new Vector2(800, (rng.Next(Raylib.GetScreenHeight(), Raylib.GetScreenWidth()) * 50));

        //Big asteroid Drawing
        Raylib.DrawCircleV(asteroidPosition1, asteroidRadius1, color);

        //Small asteroid Drawing
        Raylib.DrawCircleV(asteroidPosition2, asteroidRadius2, color);
    }
    public void Collision()
    {
        //Check collision with big asteroids
        //float radii1 = asteroidRadius1 + play.radius;
        //bool overlapBigAst = Vector2.Distance(asteroidPosition1, player stats) <= radii1;

        //Checks collision with small asteroids
        //float radii2 = asteroidRadius2 + play.radius;
        //bool overlapSmallAst = Vector2.Distance(asteroidPosition2, players stats) <= radii2;
    }

}
