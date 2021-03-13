using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector2 speed = new Vector2(5, 5);
    public Animator animator;

    public float runSpeed = 40f;
    float horizontalMove = 0f;
    float verticalMove = 0f;
    float jumpHeight = 3;
    bool jump = false;
    bool crouch = false;
    bool faceRight = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         float inputX = Input.GetAxis("Horizontal");
         float inputY = Input.GetAxis("Vertical");
         Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY, 0);
         movement *= Time.deltaTime;
         transform.Translate(movement);
         animator.SetFloat("Speed", Mathf.Abs(inputX));

        // idle --> run
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetKey("w") && jump)
        {
            verticalMove = Input.GetAxisRaw("Vertical") * jumpHeight;
            animator.SetFloat("isJumping", verticalMove);
            jump = true;
        }


    }

    void FixedUpdate()
    {
        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
        {//find controller inputs
           float moveHorizontal = Input.GetAxisRaw("Horizontal");
           float moveVertical = Input.GetAxisRaw("Vertical");
           Flip(moveHorizontal);

        }
        else
        {
            float moveHorizontal = Input.GetAxisRaw("Horizontal");
            float moveVertical = Input.GetAxisRaw("Vertical");
            Flip(moveHorizontal);
        }
        if (Input.GetKey("w") && jump)
        {
            verticalMove = Input.GetAxisRaw("Vertical") * jumpHeight;
            animator.SetFloat("isJumping", verticalMove);
            jump = true;
        }



    }

    //make sure character facing correct way
    private void Flip(float moveHorizontal)
    {
        if (moveHorizontal > 0 && !faceRight || moveHorizontal < 0 && faceRight)
        {
            faceRight = !faceRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }

}

