using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitFollow : MonoBehaviour
{
    public float speed, distance;
    private Transform player;
    public static bool trig;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if(trig)
            if (Vector2.Distance(transform.position, player.position) > distance)
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }
}
