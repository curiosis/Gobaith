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
        distance = Vector2.Distance(transform.position, player.position);
        timeBtwShots = startTimeBtwShots;
    }

    
    void Update()
    {
        if (timeBtwShots <= 0)
        {
            if(!unknownEnemy)
                Instantiate(bulletGO, bulletPoint.position, Quaternion.identity);
            else if(unknownEnemy)
                Instantiate(bulletunknown, bulletPoint.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        }
        else
            timeBtwShots -= Time.deltaTime;

        

        if (player != null)
        {
            if (distance < agroRange)
            {
                if (Vector2.Distance(transform.position, player.position) < distance)
                    transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            }

        }
    }

    public float getRot()
    {
        return transform.rotation.eulerAngles.z;
    }
}
