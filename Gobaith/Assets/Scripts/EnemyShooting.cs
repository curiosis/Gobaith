using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform bulletPoint, player;
    public GameObject bulletGO, bulletunknown;
    private float timeBtwShots, distance;
    public float startTimeBtwShots, agroRange, speed;
    public bool unknownEnemy;

    void Start()
    {
        
        timeBtwShots = startTimeBtwShots;
    }

    
    void Update()
    {
       

        

        if (player != null)
        {
            distance = Vector2.Distance(transform.position, player.position);
            if (distance < agroRange)
            {
                if (timeBtwShots <= 0)
                {
                    if (!unknownEnemy)
                        Instantiate(bulletGO, bulletPoint.position, Quaternion.identity);
                    else if (unknownEnemy)
                        Instantiate(bulletunknown, bulletPoint.position, Quaternion.identity);
                    timeBtwShots = startTimeBtwShots;
                }
                else
                    timeBtwShots -= Time.deltaTime;

                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
                //transform.LookAt(player);
            }

        }
    }
}
