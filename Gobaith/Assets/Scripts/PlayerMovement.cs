using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public string nextLevel;
    public float speed, jumpForce, checkRadius;
    private float moveInput;
    private bool isGrounded, facingRight = true;
    public Transform groundCheck;
    public LayerMask whatIsGround;
    public Animator animator;

    public GameObject activeRestartUI, player;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if ((facingRight == false && moveInput > 0) || (facingRight == true && moveInput < 0))
            Flip();
    }

    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("spike"))
        {
            activeRestartUI.SetActive(true);
            Destroy(player);
            SoundManager.PlaySound("Dead");
        }

        if (collision.CompareTag("fruit"))
            FruitFollow.trig = true;

        if (collision.CompareTag("tp"))
            LevelManager.NextLevel(nextLevel);


    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("platform")){
            this.transform.parent = other.transform;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("platform"))
        {
            this.transform.parent = null;
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}