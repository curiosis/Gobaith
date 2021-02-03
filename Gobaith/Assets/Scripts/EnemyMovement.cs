using System;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed, agroRange, startTimeBtwShots;
    public bool facingRight;
    float xValue;
    public Transform player;

    private float timeBtwShots;

    private void Start()
    {
        xValue = transform.localScale.x;
        timeBtwShots = startTimeBtwShots;
    }

    void Update()
    {
        if (facingRight)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(-xValue, xValue);
        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(xValue, xValue);
        }

        if(player != null)
        {
            float distance = Vector2.Distance(transform.position, player.position);
            try
            {
                if (distance < agroRange)
                {
                    if (timeBtwShots <= 0)
                    {
                        SoundManager.PlaySound("SlimeMovement", Math.Abs(1-(distance/agroRange)));
                        timeBtwShots = startTimeBtwShots;
                    }
                    else
                    {
                        timeBtwShots -= Time.deltaTime;
                    }
                }
            }
            catch (Exception) { }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("turnEnemy"))
        {
            if (facingRight)
                facingRight = false;
            else
                facingRight = true;
        }
    }
}
