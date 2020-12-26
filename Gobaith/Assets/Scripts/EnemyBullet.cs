using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public bool horizontal;
    public GameObject bulletEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(horizontal)
            rb.velocity = new Vector2(speed * transform.localScale.x, 0);
        else if(!horizontal)
            rb.velocity = new Vector2(0, speed * transform.localScale.y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(bulletEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
