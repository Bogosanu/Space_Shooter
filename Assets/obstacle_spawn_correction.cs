using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class obstacle_spawn_correction : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacle")
        {
            Destroy(gameObject);
        }
    }
}
