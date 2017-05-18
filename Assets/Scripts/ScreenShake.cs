using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour {

	private int shakeLife = 0;

	void Update () {
		if (shakeLife > 0) {
            transform.position = new Vector3(transform.position.x + Mathf.Sin(Time.frameCount * .3f) * .03f, 
                                             transform.position.y + Mathf.Sin(Time.frameCount * .3f) * .03f,
                                             transform.position.z);
			shakeLife--;
        }
	}

    public void Shake(int shakeLife) {
		this.shakeLife = shakeLife;
    }
}
