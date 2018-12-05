using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Leap.Unity;

public class MLControled : MonoBehaviour {

    float pas = 0.5f;
    string order = "Kick";
    public LeapServiceProvider lsp;
    WebSocket w;
    // Use this for initialization
    void Start () {
        w = lsp._WS_conn;
        //Récupération connexion WebSocket
    }
	
	// Update is called once per frame
	void Update () {
        //Lecture du socket; MAJ si nécessaire
        order = w.RecvString(); // Check format du websocket
        // Execute order
        switch (order)
        {
            
            case "ZoomIn":
                if(transform.position.z < 1) transform.Translate(0,0,+pas);
                break;
            case "ZoomOut":
                if(transform.position.z > -1) transform.Translate(0, 0,-pas);
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
            case "Fire":
                transform.Translate(0, 0, -(transform.position.z));
                break;
            case "NOP":
                break;
        }


        if (order != null) Debug.Log(order);
        // Reset order
        order = null;
    }

}
