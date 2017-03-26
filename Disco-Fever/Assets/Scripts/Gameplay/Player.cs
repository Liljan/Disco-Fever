using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : InGameObject
{
    public int width = 12;
    public int height = 10;


    private int x, y;

    public float stepSize = 1.0f;

    void Start()
    {

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (x > 0)
            {
                transform.Translate(Vector3.left * stepSize);
                x--;
            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (x < width - 1)
            {
                transform.Translate(Vector3.right * stepSize);
                x++;
                Debug.Log(x);
            }
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            if (y < height - 1)
            {
                transform.Translate(Vector3.up * stepSize);
                y++;
            }
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            if (y > 0)
            {
                transform.Translate(Vector3.down * stepSize);
                y--;
            }
        }





    }


}
