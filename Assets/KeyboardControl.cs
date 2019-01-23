using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControl : MonoBehaviour {

    private float speed = 60.0f;//a speed modifie
    float pas = 0.5f;
    private bool avail = true;
    void Start () {

	}

	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D) && avail) // To right     D
        {
            avail = false;
            transform.Rotate(Vector3.up, speed * Time.deltaTime);
            avail = true;
        }

        if (Input.GetKey(KeyCode.Q) && avail)  // To left  Q
        {
            avail = false;
            transform.Rotate(Vector3.down, speed * Time.deltaTime);
            avail = true;
        }

        if (Input.GetKey(KeyCode.Z) && avail) // UP    z
        {
            avail = false;
            transform.Rotate(Vector3.right, speed * Time.deltaTime);
            avail = true;
        }

        if (Input.GetKey(KeyCode.S) && avail)  // down s
        {
            avail = false;
            transform.Rotate(Vector3.left, speed * Time.deltaTime);
            avail = true;
        }
        if (Input.GetKey(KeyCode.W) && avail) {
            avail = false;
            if(transform.position.z < 1) transform.Translate(0,0,+pas* Time.deltaTime);
            avail = true;
          }

        if (Input.GetKey(KeyCode.X) && avail) {
            avail = false;
            if(transform.position.z > -1) transform.Translate(0,0,-pas* Time.deltaTime);
            avail = true;
          }
    }
}
