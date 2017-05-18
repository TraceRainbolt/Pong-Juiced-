using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerBehaviourScript : MonoBehaviour {
    public GameObject ball;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector2(transform.position.x, ball.transform.position.y);
	}

    void OnTriggerEnter(Collider other)
    {
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-rb.velocity.x, rb.velocity.y);
    }
}
