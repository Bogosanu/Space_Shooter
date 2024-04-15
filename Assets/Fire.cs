using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public Transform Bullet_Spawn;
    public GameObject Bullet;
    public float bulletspeed = 10f;
    public int ok_tofire = 0;
    static public int frames_to_fire = 35;

    void Update()
    {
        if (ok_tofire == 0)
        {
            var bullet = Instantiate(Bullet, Bullet_Spawn.position, Bullet_Spawn.rotation);
            bullet.GetComponent<Rigidbody>().velocity = Bullet_Spawn.forward * bulletspeed;
            ok_tofire = frames_to_fire;
        }
        ok_tofire--;
    }
}
