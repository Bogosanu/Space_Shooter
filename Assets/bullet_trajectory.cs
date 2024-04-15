using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_trajectory : MonoBehaviour
{
    public float life = 1;
    [SerializeField] public AudioSource hiteffect;

    void Awake()
    {
        Destroy(gameObject, life);
    }
    void OnCollisionEnter(Collision collisioninfo)
    {
        Destroy(gameObject);
    }
}
