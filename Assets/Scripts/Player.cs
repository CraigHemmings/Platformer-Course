using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] float jump = 200f;

    void Update()
    {
        // taking user input for left and right keys, and assigning them into a variable
        float horizontal = Input.GetAxis("Horizontal") * moveSpeed;
        
        // storying the getcomponent rigidbody2d into a variable, this access's the rigidbody component
        Rigidbody2D rigidbody2D = GetComponent<Rigidbody2D>();
        // this allows the user to move by hitting the left and right arrow keys
        rigidbody2D.velocity = new Vector2(horizontal, rigidbody2D.velocity.y);

        Animator animator = GetComponent<Animator>();
        bool walking = horizontal != 0;
        animator.SetBool("Walk", walking);

        if (horizontal != 0)
        {
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.flipX = horizontal < 0;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            rigidbody2D.AddForce(Vector2.up * jump);
        }
    }
}
  