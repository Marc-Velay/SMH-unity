using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MLControled : MonoBehaviour {

    float pas = 0.8f;
    string order = "RotD";
    WebSocket w;
    // Use this for initialization
    IEnumerator Start () {
        w = new WebSocket(new Uri("ws://10.8.95.155:8888/ws"));
        yield return StartCoroutine(w.Connect());
        //Connexion WebSocket
    }
	
	// Update is called once per frame
	void Update () {
        //Lecture du socket; MAJ si nécessaire
        order = w.RecvString(); // Check format du websocket
        // Execute order
        switch (order)
        {
            
            case "ZoomIn":
                transform.Translate(0,0,-pas);
                break;
            case "ZoomOut":
                transform.Translate(0, 0,pas);
                break;
            case "RotD":
                transform.Rotate(Vector3.down * pas);
                break;
            case "RotG":
                transform.Rotate(Vector3.up * pas);
                break;
            case "Kick":
                transform.Rotate(Vector3.right * pas);
                break;
            case "NOP":
                break;
        }


        if (order != null) Debug.Log(order);
        // Reset order
        //order = null;
    }

}
