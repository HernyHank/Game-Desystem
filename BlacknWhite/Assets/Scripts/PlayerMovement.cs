using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float jumpForce = 15f;

    private Rigidbody2D rb;

    private Animator ani;
    private SpriteRenderer sr;

    public Animator idolOfSholkaController;
    public int canMoveMultiplier;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        canMoveMultiplier = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //touchingStatue
/*        if (idolOfSholkaController.GetBool("polkaCanMove") == false)
        {
            canMoveMultiplier = 0;
        }
        else
        {
            canMoveMultiplier = 1;
        }*/
        EvaluateMovement();

    }

    private void EvaluateMovement()
    {
        //movement left right
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(canMoveMultiplier * moveInput * moveSpeed, Mathf.Clamp(rb.velocity.y, -30, 50));

        if (moveInput != 0)
        {
            ani.SetBool("isRunning", true);
            if (moveInput > 0)
            {
                sr.flipX = false;
            }
            else
            {
                sr.flipX = true;
            }
        }
        else
        {
            ani.SetBool("isRunning", false);
        }

        //attack
        if (Input.GetKey(KeyCode.E))
        {
            ani.SetBool("isAttacking", true);
        }
        else
        {
            ani.SetBool("isAttacking", false);
        }

            //jumping
            bool isGrounded = Physics2D.OverlapCircle(this.gameObject.transform.position, 0.1f, 1 << LayerMask.NameToLayer("Ground"));
        if(Input.GetButtonDown("Jump") && isGrounded && canMoveMultiplier != 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        if (Input.GetButtonUp("Jump") && rb.velocity.y >= 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }


    }
}
