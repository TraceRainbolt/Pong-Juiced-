using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourScript : MonoBehaviour {

    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        mouse.z = 10;
        transform.position = new Vector2(transform.position.x, Camera.main.ScreenToWorldPoint(mouse).y);
    }

}
