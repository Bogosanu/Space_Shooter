using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_section_trigger : MonoBehaviour
{
    public GameObject levelsection;

    private void OnTriggerEnter(Collider other)
    {
        Vector3 playerPosition = transform.position;
        Vector3 instantiatePosition = new Vector3(83.58149f, -40.55787f, playerPosition.z + 1406.2f);
        Instantiate(levelsection, instantiatePosition, Quaternion.identity);
    }
}
