using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D TheRB;
    public float moveSpeed;
    public float jumpForce;


    public Transform groundPoint;
    private bool isOnGround;
    public LayerMask whatIsGround;

    public Animator anim;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move sideways
        TheRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, TheRB.velocity.y);

        //handle direction change
        if (TheRB.velocity.x < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (TheRB.velocity.x > 0)
        {
            transform.localScale = Vector3.one;
        }



        //check if on ground
        isOnGround = Physics2D.OverlapCircle(groundPoint.position, .2f, whatIsGround);



        //jumping
        if (Input.GetButtonDown("Jump") && isOnGround)
        {
            TheRB.velocity = new Vector2(TheRB.velocity.x, jumpForce);
        }








        anim.SetBool("isonGround", isOnGround);
        anim.SetFloat("speed", Mathf.Abs( TheRB.velocity.x));
    }
}
