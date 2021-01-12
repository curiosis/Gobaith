using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform bulletPoint;
    public GameObject bulletGO, bulletSandSlimeGO;
    private float timeBtwShots;
    public float startTimeBtwShots;
    public bool sandSlime;

    void Start()
    {
        timeBtwShots = startTimeBtwShots;
    }

    
    void Update()
    {
        if (timeBtwShots <= 0)
        {
            if(!sandSlime)
                Instantiate(bulletGO, bulletPoint.position, Quaternion.identity);
            else if(sandSlime)
                Instantiate(bulletSandSlimeGO, bulletPoint.position, Quaternion.identity);
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
