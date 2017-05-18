using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerBehaviourScript : MonoBehaviour {
    public GameObject ball;

	void Update () {
        transform.position = new Vector2(transform.position.x, ball.transform.position.y);
	}

}
