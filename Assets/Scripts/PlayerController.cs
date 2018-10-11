using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float topSpeed;
    public float acceleration;
    public float jumpPower;

    Rigidbody2D rb;
    SpriteRenderer spriteRen;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        spriteRen = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(new Vector2(acceleration, 0));
            spriteRen.flipX = false;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(new Vector2(-acceleration, 0));
            spriteRen.flipX = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, jumpPower));
        }

        if (rb.velocity.x > topSpeed)
            rb.velocity = new Vector2(topSpeed, rb.velocity.y);
        else if (rb.velocity.x < -topSpeed)
            rb.velocity = new Vector2(-topSpeed, rb.velocity.y);
    }
}
