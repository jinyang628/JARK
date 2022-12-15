using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float horizontal;
    [SerializeField] public float speed = 4f;
    [SerializeField] public float jumpingPower = 6f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D player;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    private Animator playerAnimator;

    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (horizontal == 0)
        {
            playerAnimator.SetBool("isWalking", false);
        }
        else
        {
            playerAnimator.SetBool("isWalking", true);
        }

        /*
        if (Input.GetKeyDown("f"))
        {
            playerAnimator.SetTrigger("sizeChanging");
        }
        */


        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            player.velocity = new Vector2(player.velocity.x, jumpingPower);
        }


        //The below is to create a difference between tapping and holding the Jump button
        /*
        if (Input.GetButtonUp("Jump") && player.velocity.y > 0f)
        {
            player.velocity = new Vector2(player.velocity.x, player.velocity.y * 0.5f);
        }
        */

        playerAnimator.SetBool("isJumping", !IsGrounded());
        Flip();
    }

    private void FixedUpdate()
    {
        player.velocity = new Vector2(horizontal * speed, player.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

}
