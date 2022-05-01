using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // taking user input for left and right keys, and assigning them into a variable
        float horizontal = Input.GetAxis("Horizontal");
        // storying the getcomponent rigidbody2d into a variable, this access's the rigidbody component
        Rigidbody2D rigidbody2D = GetComponent<Rigidbody2D>();
        // this allows the user to move by hitting the left and right arrow keys
        rigidbody2D.velocity = new Vector2(horizontal, rigidbody2D.velocity.y);
    }
}
