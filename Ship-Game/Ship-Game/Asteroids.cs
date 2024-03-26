using Raylib_cs;
using System.Numerics;
internal class Asteroids
{  
    static Random rng = new Random();

    static int[] radii = { 15, 25 };

    //General values
    int asteroidVelocity = 200;    
    Color color = Color.Black;
    public Vector2 position;
    public int radius;


    public Asteroids()
    {
   
    }
        
    //Random position generator
    public void Random()
    {
        position = new Vector2(1600, (rng.Next(0, 32) * 50));
        
        int radiiIndex = rng.Next(radii.Length);
        radius = radii[radiiIndex];
    }
    public void DrawAsteroids()
    {
        Raylib.DrawCircleV(position, radius, color);
    }

    //Check collision between player and asteroids    
    //public void Collision(Player_test play)
    //{       
    //    float radii1 = radius + play.playerRadius;
    //    bool overlapBigAst = Vector2.Distance(position, play.playerPosition) <= radii1;
    //}
    public void Movement()
    {
        position.X -= asteroidVelocity * Raylib.GetFrameTime(); // make asteroids move across the screen
    }

}
