using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public float movmentSpeed;
    public float jumpForce;
    public Rigidbody2D rig;

    // FixedUpdate called every 0.02 seconds
    void FixedUpdate()
    {
        float xInput = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(xInput * movmentSpeed, rig.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && IsGrounded())
        {
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position + new Vector3(0,-0.1f,0),Vector2.down,0.2f);
        return hit.collider != null;
    }
}
