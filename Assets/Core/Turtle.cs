using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtle : MonoBehaviour
{
    public GameObject penShape;
    public Color currentColor = Color.white;
    public Color red = Color.red;
    public Color yellow = Color.yellow;
    public Color green = Color.green;
    public Color blue = Color.blue;
    public Color black = Color.black;
    public Color white = Color.white;

    //   // Use this for initialization
    //   public virtual void Start ()
    //   {

    //}

    //   // Update is called once per frame
    //   public virtual void Update ()
    //   {

    //}

    public virtual void Awake()
    {

    }

    public virtual void forward(int quantity)
    {
        if (quantity < 0)
            return;

        while (quantity != 0)
        {
            transform.position += transform.forward;
            GameObject trail = Instantiate(penShape, transform.position, transform.rotation) as GameObject;
            //trail.tag = "TurtleTrail";
            MeshRenderer renderer = trail.GetComponent<MeshRenderer>();
            renderer.material.color = currentColor;
            quantity--;
        }
    }

    public virtual void backward(int quantity)
    {
        if (quantity < 0)
            return;

        while (quantity != 0)
        {
            transform.position -= transform.forward;
            GameObject trail = Instantiate(penShape, transform.position, transform.rotation) as GameObject;
            trail.tag = "TurtleTrail";
            MeshRenderer renderer = trail.GetComponent<MeshRenderer>();
            renderer.material.color = currentColor;
            quantity--;
        }
    }

    public virtual void right(int angle)
    {
        transform.Rotate(0, angle, 0);
    }

    public virtual void left(int angle)
    {
        transform.Rotate(0, -angle, 0);
    }

    public virtual void up(int angle)
    {
        transform.Rotate(-angle, 0, 0);
    }

    public virtual void down(int angle)
    {
        transform.Rotate(angle, 0, 0);
    }

    public virtual void clear()
    {
        GameObject[] gos = GameObject.FindGameObjectsWithTag("TurtleTrail");
        foreach (GameObject gameObject in gos)
            Destroy(gameObject);
    }

    public virtual void pencolor(Color color)
    {
        currentColor = color;
    }

    public virtual void pencolor(int r, int g, int b)
    {
        currentColor = new Color(r / 255, g / 255, b / 255, 1);
    }

    public virtual void pencolor(int r, int g, int b, int a)
    {
        currentColor = new Color(r / 255, g / 255, b / 255, a / 255);
    }
}
