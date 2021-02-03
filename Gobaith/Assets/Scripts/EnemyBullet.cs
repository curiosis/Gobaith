using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public bool horizontal, sandSlime;
    public GameObject bulletEffect;

    public float startDestroyTimer;
    private float destroyTimer;

    private Transform player;
    private Vector2 target;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        destroyTimer = startDestroyTimer;

        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
    }

    void Update()
    {
        if (!sandSlime)
        {
            if (horizontal)
                rb.velocity = new Vector2(speed * transform.localScale.x, 0);
            else if (!horizontal)
                rb.velocity = new Vector2(0, speed * transform.localScale.y);

            if (destroyTimer <= 0)
                Destroy(gameObject);
            else
                destroyTimer -= Time.deltaTime;
        }
        else if (sandSlime)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
            if (transform.position.x == target.x && transform.position.y == target.y)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(bulletEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}