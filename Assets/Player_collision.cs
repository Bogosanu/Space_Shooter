using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_collision : MonoBehaviour
{
    public player_movement movement;
    [SerializeField] public AudioSource deatheffect;
    [SerializeField] public AudioSource wineffect;
    public GameObject crash;
    private void OnCollisionEnter(Collision collisioninfo)
    {
        if(collisioninfo.collider.tag == "Obstacle" || collisioninfo.collider.tag == "Enemy"  )
        {
            deatheffect.Play();
            GameObject particleEffect = Instantiate(crash, transform.position, Quaternion.identity);
            FindAnyObjectByType<GameManager>().GameOver();

        }
        if (collisioninfo.collider.tag == "Victory")
        {
            wineffect.Play();
            FindAnyObjectByType<GameManager>().Victory();

        }
    }
}
