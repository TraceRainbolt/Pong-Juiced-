using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviourScript : MonoBehaviour {

    public GameObject bounceParticle;
    public float ymin, ymax;

    private Rigidbody2D rb;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(4, 4);
    }

	void FixedUpdate () {
		if(transform.position.y <= ymin || transform.position.y >= ymax) {
            rb.velocity = new Vector2(rb.velocity.x, -rb.velocity.y);
        }
	}

    void OnTriggerEnter2D(Collider2D other) {
        rb.velocity = new Vector2(-1.1f * rb.velocity.x, rb.velocity.y);
        Camera.main.GetComponent<ScreenShake>().Shake((int) (5*Mathf.Abs(rb.velocity.x)));
        GameObject particles = (GameObject) Instantiate(bounceParticle, transform.position, Quaternion.identity);
        Destroy(particles, 3);
    }
}
