using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Vector2 velocity;
    public Rigidbody2D rb;
    public float speed;
    public bool playerIsMoving;

    //This help deactivating the movement mechanism when the player is dead
    public static bool playerIsDead;

    //Initialize player movement
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerIsDead = false;
    }

    //Move the player using FixedUpdate for smoother movements
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime * speed);
    }

    //This constantly update if the player is moving or not
    private void Update()
    {
        velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            playerIsMoving = true;
        }
        else playerIsMoving = false;
    }
}
