using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public float speed;
    public float distance;
    bool isRight = true;
    public Transform groundCheck;
    public Rigidbody2D rb;

    void Start()
    {
    }

    void Update()
    {
        WalkAndFlipEnemy();
    }

    public void WalkAndFlipEnemy()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D ground = Physics2D.Raycast(groundCheck.position, Vector2.down, distance);
        if (ground.collider == false)
        {
            if (isRight == true)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                isRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                isRight = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Tiro")) 
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
    }
}
