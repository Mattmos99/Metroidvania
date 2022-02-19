using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D TheRB;
    public float moveSpeed;
    public float jumpForce;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TheRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, TheRB.velocity.y);
    }
}