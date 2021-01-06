using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform bulletPoint;
    public GameObject bulletGO;
    private float timeBtwShots;
    public float startTimeBtwShots;

    void Start()
    {
        timeBtwShots = startTimeBtwShots;
    }

    
    void Update()
    {
        if (timeBtwShots <= 0)
        {
            Instantiate(bulletGO, bulletPoint.position, bulletPoint.rotation);
            timeBtwShots = startTimeBtwShots;
        }
        else
            timeBtwShots -= Time.deltaTime;
    }

    public float getRot()
    {
        return transform.rotation.eulerAngles.z;
    }
}
