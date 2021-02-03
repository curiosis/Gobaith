using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtack : MonoBehaviour
{
    public GameObject atackParticleSystem;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
            Instantiate(atackParticleSystem, transform.position, Quaternion.identity);
    }
}
