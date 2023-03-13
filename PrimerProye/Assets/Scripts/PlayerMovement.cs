// David Santiago Vieyra García | A01656030 && José Daniel Rodríguez Cruz | A01781933

// This script is attached to the player object in the scene and is used to control the player's movement.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // We declare the variables that will be used in the script.
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator anim;

    // Jumpable ground layer mask. This is used to check if the player is grounded, for allowing the player to jump or not. 
    [SerializeField] private LayerMask jumpableGround;

    // Horizontal movement direction. This is used to move the player left or right.
    private float dirX; 
    // Movement speed. This is used to control the player's movement speed. 7f is the default value. 
   [SerializeField] private float moveSpeed = 7f; 
    // Jump force. This is used to control the player's jump force. 10f is the default value.
   [SerializeField] private float jumpForce = 10f;
    // enum to control the player's movement state. This is used to control the player's animations. enum means that the variable can only have one of the values that are inside the curly brackets.
   private enum MovementState { idle, running, jumping, falling };

    // Audio source to play the jump sound. This is used to play the jump sound when the player jumps.
   [SerializeField] private AudioSource jumpSound;
    
    // int wholeNumber = 16;
    // float decimalNumber = 4.54f;
    // string text = "blabla"; 
    // bool boolean = false;

    // Start is called before the first frame update
    private void Start()
    {
        // Here we get the components of the player object and store them in the variables that we declared at the beginning of the script.
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        // Here we get the horizontal movement direction from the input manager. This is used to move the player left or right.
        dirX = Input.GetAxis("Horizontal");
        // In this part of the script we set the player's velocity to move the player left or right.
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        // Here we check if the player is grounded and if the player pressed the jump button or W ot UpArrow. If the player is grounded and pressed one of these keybinds, the player jumps.
        if ((Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && IsGrounded())
        {
            // Here we play the jump sound.
            jumpSound.Play();
            // Here we set the player's velocity to make the player jump with the jump force.
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }   

        // Here we call the UpdateAnimation method to update the player's animations.
        UpdateAnimation();

    }
    // This method is used to update the player's animations. In this method we check the player's movement state and set the player's animation state to the corresponding animation.
    private void UpdateAnimation()
    {
        MovementState state;

        if (dirX > 0f)
        {
            state = MovementState.running;
            // Here we flip the player's sprite to face the right direction.
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            state = MovementState.running;
            // Here we flip the player's sprite to face the left direction.
            sprite.flipX = true;
        }
        else
        {
            // When there is no movement in the x axis, the player is idle.
            state = MovementState.idle;
        }
            // Here we check if the player is jumping or falling and set the player's animation state to the corresponding animation.
        if (rb.velocity.y > .1f)
        {
            state = MovementState.jumping;
        }
        else if (rb.velocity.y < -.1f)
        {
            state = MovementState.falling;
        }
        // Setinteger is used to set the player's animation state to the corresponding integer value. Easier to use than strings.
        anim.SetInteger("state", (int)state);
    }

    private bool IsGrounded()
    {
        // Finally we return if the player is grounded or not. This is used to check if the player is touching a jumpableGround, to allow the player to jump or not.
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
