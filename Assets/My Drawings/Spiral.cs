using UnityEngine;
using System.Collections;

public class Spiral : Turtle
{

    int steps;

    void Start()
    {
        steps = 1;
        pencolor(red);
    }
        
    void Update()
    {
        forward(steps);
        right(89);
        steps = steps + 1;
    }
}
