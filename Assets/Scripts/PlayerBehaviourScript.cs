﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 mouse = Input.mousePosition;
        mouse.z = 10;
        transform.position = new Vector2(transform.position.x, Camera.main.ScreenToWorldPoint(mouse).y);
	}

    void OnTriggerEnter(Collider other)
    {
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-rb.velocity.x, rb.velocity.y);
    }
}
