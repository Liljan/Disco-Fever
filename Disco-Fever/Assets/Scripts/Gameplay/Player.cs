using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : InGameObject
{
    public int width = 12;
    public int height = 10;

    private int x, y;

    public float stepSize = 1.0f;

    private Vector3 targetPosition;

    public float speed = 1.0f;

    public LayerMask groundLayers;
    private bool isGrounded;

    private Animator animator;

    public void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        targetPosition = transform.position;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (x > 0)
            {
                targetPosition.x -= stepSize;
                x--;
            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (x < width - 1)
            {
                targetPosition.x += stepSize;
                x++;
            }
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            if (y < height - 1)
            {
                targetPosition.y += stepSize;
                y++;
            }
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            if (y > 0)
            {
                targetPosition.y -= stepSize;
                y--;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
        }

        isGrounded = Physics.Linecast(transform.position + Vector3.forward, transform.position + Vector3.back, groundLayers);
        Debug.DrawLine(transform.position + Vector3.forward, transform.position + Vector3.back);

        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

        if (!isGrounded)
        {
            Debug.Log("YOU LOST");
        }
    }
}
