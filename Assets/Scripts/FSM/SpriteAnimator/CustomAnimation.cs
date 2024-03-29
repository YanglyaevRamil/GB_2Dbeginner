using System.Collections.Generic;
using UnityEngine;

public class CustomAnimation
{
    public Track Track;
    public List<Sprite> Sprites;
    public bool Loop;
    public float Speed = 10.0f;
    public float Counter;
    public bool Sleeps;

    public void Update(float dt)
    {
        if (Sleeps)
            return;

        Counter += dt * Speed;

        if (Loop)
        {
            while (Counter > Sprites.Count)
            {
                Counter -= Sprites.Count;
            }
        }
        else if (Counter > Sprites.Count)
        {
            Counter = Sprites.Count - 1;
            Sleeps = true;
        }
    }
}
