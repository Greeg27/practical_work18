using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticEnemie1Script : MonoBehaviour
{
    [SerializeField] Transform player;

    void Update()
    {
        if (player.position.x > transform.position.x)
        {
            transform.rotation = Quaternion.identity;
        }
    }
}
