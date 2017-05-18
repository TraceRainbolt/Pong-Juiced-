using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviourScript : MonoBehaviour {
    public float ymin, ymax;

    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(4, 4);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        float yPos = transform.position.y;
        if(yPos <= ymin || yPos >= ymax)
        {
            rb.velocity = new Vector2(rb.velocity.x, -rb.velocity.y);
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        print("hello");
        rb.velocity = new Vector2(-rb.velocity.x, rb.velocity.y);
    }
}
