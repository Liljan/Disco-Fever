using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : InGameObject
{
    public int lanes = 8;
    private int currentLane = 0;

    public float stepSize = 1.0f;

    void Start()
    {

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (currentLane > 0)
            {
                transform.Translate(Vector3.left * stepSize);
                currentLane--;
            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (currentLane < lanes - 1)
            {
                transform.Translate(Vector3.right * stepSize);
                currentLane++;
                Debug.Log(currentLane);
            }
        }



    }


}
