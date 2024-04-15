using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_movement : MonoBehaviour
{
    public Rigidbody rb;
    public float strafeSpeed = 25f; // Speed of the sideward movement
    public float upwardSpeed = 10f; // Speed of the upward movement
    public float rotationSpeed = 2250f; // Degrees per second for the rotation
    public int inta = 10;
    public int intb = 20;
    private int interval;
    private int ok_tomove = 0;

    private void Start()
    {
        interval = Random.Range(inta, intb);
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        if (ok_tomove == 0)
        {
            Vector3 rightMovement;
            Quaternion rot;
            // Shift to the right and upward by directly setting the velocity
            if (interval % 2 == 0)
            {
                rightMovement = transform.right * strafeSpeed;
                rot = rb.rotation * Quaternion.Euler(0f, 0f, rotationSpeed * Time.deltaTime);
            }
            else
            {
                rightMovement = transform.right * -strafeSpeed;
                rot = rb.rotation * Quaternion.Euler(0f, 0f, -rotationSpeed * Time.deltaTime);
            }

            Vector3 upwardMovement = transform.up * upwardSpeed;

            // Add the right and upward movement to the current forward velocity
            rb.velocity += rightMovement;
            rb.velocity += upwardMovement;

            // Perform a barrel roll rotation around the forward axis
            rb.MoveRotation(rot);
            ok_tomove = interval;

        }
        ok_tomove--;
        
    }
}
