using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour {

    private int shakeCounter = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (shakeCounter > 0)
        {
            transform.position = new Vector3(transform.position.x + Mathf.Sin(Time.frameCount*.3f)*.03f, 
                                             transform.position.y + Mathf.Sin(Time.frameCount*.3f)*.03f,
                                             transform.position.z);
            shakeCounter--;
        }
	}

    public void Shake(int shakeCounter)
    {
        this.shakeCounter = shakeCounter;
    }
}
