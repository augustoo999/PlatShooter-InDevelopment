using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private bool isGround = true;
    public float ForcaPulo;
    private float direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        AndarPlayer();
        PuloPlayer();
    }

    public void AndarPlayer()
    {
        direction = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2 (direction * speed, rb.velocity.y);
    }

    public void PuloPlayer()
    {
        if (isGround && Input.GetButtonDown("Jump")) 
        {
            rb.velocity = Vector2.up * ForcaPulo;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") 
        {
            isGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") 
        {
            isGround = false;
        }
    }
}
