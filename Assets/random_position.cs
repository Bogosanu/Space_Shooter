using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_position : MonoBehaviour
{

        
    public float minDistance = -100f;
    public float maxDistance = 100f;

    void Start()
    {
        // Generate a random distance within the specified range
        float randomDistance = Random.Range(minDistance, maxDistance);

        // Get the current position of the object
        Vector3 currentPosition = transform.position;

        // Create a new position vector with the random distance added to the X axis
        Vector3 newPosition = new Vector3(currentPosition.x, currentPosition.y, currentPosition.z + randomDistance);

        // Set the object's position to the new position
        transform.position = newPosition;
    }

}
