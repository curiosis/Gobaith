using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtack : MonoBehaviour
{
    public GameObject atackParticleSystem;
    public float damageRange, startTimeBtwShots;
    float distance;
    float timeBtwShots;

    private void Start()
    {
        timeBtwShots = startTimeBtwShots;
    }

    void Update()
    {
        GameObject enemy = GameObject.FindGameObjectWithTag("Wizard");

        distance = Vector2.Distance(transform.position, enemy.transform.position);
        if (timeBtwShots <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {

                Instantiate(atackParticleSystem, transform.position, Quaternion.identity);
                SoundManager.PlaySound("PlayerAttack", 0);
                if (damageRange > distance)
                    Debug.Log("Frajer");
                timeBtwShots = startTimeBtwShots;
            }
        }
        else
            timeBtwShots -= Time.deltaTime;
        
    }
}
