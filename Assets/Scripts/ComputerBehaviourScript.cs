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

}
