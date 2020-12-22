using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public bool facingRight;
    float xValue;

    private void Start()
    {
        xValue = transform.localScale.x;
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
