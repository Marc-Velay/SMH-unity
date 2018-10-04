using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Send : MonoBehaviour {

    WebSocket w;
    string label; // ZoomIn    ZoomOut  Reload   No   RotD    RotG   Kick
    bool ready;
    string record;
    int frames;


    // Use this for initialization
    IEnumerator Start () {
        // Recupérer la connexion
        w = new WebSocket(new Uri("ws://echo.websocket.org"));
        yield return StartCoroutine(w.Connect());
        ready = false;
        frames = 0;
    }
	
	// Check if there is a string to append
	void Update () {
		
	}
}
