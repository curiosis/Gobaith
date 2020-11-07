using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public string actualLevel;
    public float speed, jumpForce, checkRadius;
    private float moveInput;
    private bool isGrounded;
    public Transform groundCheck;
    public LayerMask whatIsGround;

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
    }

    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
            
        Debug.Log(isGrounded);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "spike")
            SceneManager.LoadScene(actualLevel);
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
}