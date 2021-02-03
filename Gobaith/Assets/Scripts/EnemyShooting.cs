using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform bulletPoint, player;
    public GameObject bulletGO, bulletunknown;
    private float timeBtwShots, timeBtwSound, distance;
    public float startTimeBtwShots, startTimeBtwSound, agroRange, speed;
    public bool unknownEnemy;

    void Start()
    {
        timeBtwShots = startTimeBtwShots;
        timeBtwSound = startTimeBtwSound;
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
                    {
                        Instantiate(bulletunknown, bulletPoint.position, Quaternion.identity);
                        SoundManager.PlaySound("UnknownShot", 0);
                    }
                        

                    timeBtwShots = startTimeBtwShots;
                }
                else
                    timeBtwShots -= Time.deltaTime;

                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
                Vector3 dir = player.position - transform.position;
                float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            }

            if (distance < agroRange * 2)
            {
                if (timeBtwSound <= 0)
                {
                    SoundManager.PlaySound("UnknownMovement", Math.Abs(1 - (distance / agroRange)));
                    timeBtwSound = startTimeBtwSound;
                }
                else
                    timeBtwSound -= Time.deltaTime;
            }

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            Debug.Log("Hahaha");
        }
    }
}
