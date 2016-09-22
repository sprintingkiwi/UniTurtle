using UnityEngine;
using System.Collections;

public class turtle1 : MonoBehaviour
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



    #region TURTLE functions

    public GameObject SHAPE;

    public void forward(int quantity)
    {
        if(quantity < 0)
            return;

        while(quantity != 0)
        {
            transform.position += transform.forward;
            GameObject trail = Instantiate(SHAPE, transform.position, transform.rotation) as GameObject;
            trail.tag = "TurtleTrail";
            MeshRenderer renderer = trail.GetComponent<MeshRenderer>();
            renderer.material.color = currentColor;
            quantity--;
        }
    }

    public void backward(int quantity)
    {
        if(quantity < 0)
            return;

        while(quantity != 0)
        {
            transform.position -= transform.forward;
            GameObject trail = Instantiate(SHAPE, transform.position, transform.rotation) as GameObject;
            trail.tag = "TurtleTrail";
            MeshRenderer renderer = trail.GetComponent<MeshRenderer>();
            renderer.material.color = currentColor;
            quantity--;
        }
    }

    void right(int angle)
    {
        transform.Rotate(0, angle, 0);
    }

    void left(int angle)
    {
        transform.Rotate(0, -angle, 0);
    }

    void up(int angle)
    {
        transform.Rotate(-angle, 0, 0);
    }

    void down(int angle)
    {
        transform.Rotate(angle, 0, 0);
    }

    void clear()
    {
        GameObject[] gos = GameObject.FindGameObjectsWithTag("TurtleTrail");
        foreach(GameObject gameObject in gos)
            Destroy(gameObject);
    }

    Color currentColor = Color.white;
    Color red = Color.red;
    Color yellow = Color.yellow;
    Color green = Color.green;
    Color blue = Color.blue;
    Color black = Color.black;
    Color white = Color.white;

    void pencolor(Color color)
    {
        currentColor = color;
    }

    void pencolor(int r, int g, int b)
    {
        currentColor = new Color(r/255, g/255, b/255, 1);
    }

    void pencolor(int r, int g, int b, int a)
    {
        currentColor = new Color(r/255, g/255, b/255, a/255);
    }
    #endregion
}
