using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MLControled : MonoBehaviour {

    float pas = 0.2f;
    string order = null;
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
        }
    

        // Reset order
        order = null;
    }

}
