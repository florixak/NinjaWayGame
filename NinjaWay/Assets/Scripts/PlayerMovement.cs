using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Player player;
    private float speed;
    private Rigidbody2D rb;
    private Animator anim;

    private Vector2 movement;

    void Start()
    {
        player = GetComponent<Player>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
        speed = player.walkSpeed;
    }

    void FixedUpdate()
    {
        movement = Vector2.zero;

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement != Vector2.zero)
        {
            Move();
            anim.SetFloat("Horizontal", movement.x);
            anim.SetFloat("Vertical", movement.y);
            anim.SetBool("Moving", true);
        }
        else
        {
            anim.SetBool("Moving", false);
        }
    }

    private void Move()
    {
        rb.MovePosition(rb.position + movement.normalized * speed * Time.deltaTime);
    }
}
