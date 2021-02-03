using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtack : MonoBehaviour
{
    public GameObject atackParticleSystem;
    public float damageRange;
    float distance;

    void Update()
    {
        GameObject enemy = GameObject.FindGameObjectWithTag("Wizard");

        distance = Vector2.Distance(transform.position, enemy.transform.position);

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(atackParticleSystem, transform.position, Quaternion.identity);
            if (damageRange > distance)
                Debug.Log("Frajer");
        }
    }
}
