using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_death : MonoBehaviour
{
    public GameObject crash;
    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Bullet")
        {
            GameManager.score += 10;
            GameObject particleEffect = Instantiate(crash, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if(collisioninfo.collider.tag == "Obstacle")
        {
            Destroy(gameObject);
        }

        if (collisioninfo.collider.tag == "Enemy")
        {
           // GameObject particleEffect = Instantiate(crash, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
