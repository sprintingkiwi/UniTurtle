using UnityEngine;
using System.Collections;

public class turtle : MonoBehaviour {

    public GameObject point;

    void forward (int steps)
    {
        while (steps > 0)
        {
            transform.position += transform.forward;
            print(steps);
            steps -= 1;
            Object.Instantiate(point, transform.position, transform.rotation);
        } 
    }

    void right (int angle)
    {
        transform.Rotate(0, angle, 0);
    }


    int passi;

    // Use this for initialization
    void Start ()
    {
        passi = 1;
    }
	
	// Update is called once per frame
	void Update ()
    {
        forward(passi);
        right(88);
        passi = passi + 1;
    }
}
