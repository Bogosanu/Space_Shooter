using UnityEngine;

public class player_movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardSpeed = 5f; // Speed of the forward movement
 
    public float rotationSpeed = 125f; // Speed of the rotation
    public Vector3 rotateAroundPoint; // Point around which the object will rotate
    public Vector3 rotationAxis = Vector3.forward; // Axis around which the object will rotate


    public AudioSource lvlup1;
    public AudioSource lvlup2;

    private bool lvl1 = false;
    private bool lvl2 = false;  
    void Start()
    {
        rotateAroundPoint = new Vector3(gameObject.transform.position.x, 9f, -12.31f);
        Application.targetFrameRate = 55;
        QualitySettings.vSyncCount = 0;
        rb.velocity = transform.forward * forwardSpeed; // Set initial forward velocity
    }

    void FixedUpdate()
    {
        if (GameManager.score <= 100)
        {
            forwardSpeed = 5f;
            rotationSpeed = 125f;
            Fire.frames_to_fire = 35;
        }


        if (GameManager.score > 100 && GameManager.score < 200) 
        {
            if (lvl1 == false)
            {
                lvlup1.Play();
                lvl1 = true;
            }
            forwardSpeed = 6f;
            rotationSpeed = 150f;
            Fire.frames_to_fire = 25;
        }

        if (GameManager.score > 200)
        {
            if (lvl2 == false)
            {
                lvlup2.Play();
                lvl2 = true;
            }
            Fire.frames_to_fire = 15;
            forwardSpeed = 7f;
            rotationSpeed = 175f;
        }
        Application.targetFrameRate = 55;
        // Apply constant forward velocity
        rb.velocity += transform.forward * forwardSpeed;
        GameManager.score += 0.036f;

        if (Input.GetKey(KeyCode.A))
        {
            RotateAroundPoint(-1);
        }
        // Check for input from the D key to rotate right
        else if (Input.GetKey(KeyCode.D))
        {
            RotateAroundPoint(1);
        }
    }

    void RotateAroundPoint(int direction)
    {
        transform.RotateAround(rotateAroundPoint, rotationAxis, rotationSpeed * direction * Time.deltaTime);
    }
}
