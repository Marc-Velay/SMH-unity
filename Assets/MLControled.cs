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
    Vector3 originalPos;

    // Use this for initialization
    void Start () {
        //w = lsp._WS_conn;
        //Récupération connexion WebSocket
        originalPos = transform.position;
    }

	// Update is called once per frame
	void Update () {
        //Lecture du socket; MAJ si nécessaire

        order = lsp._WS_conn.RecvString(); // Check format du websocket
        // Execute order
        switch (order)
        {

            case "ZoomIn":
                if(transform.position.z < 0.75) transform.Translate( new Vector3(0, 0, +0.1f) );//transform.Translate(0,0,+pas);
                break;
            case "ZoomOut":
                if(transform.position.z > -0.75) transform.Translate( new Vector3(0, 0, -0.1f) ); //transform.Translate(0, 0,-pas);
                break;
            case "RotD":
                //transform.Rotate(Vector3.down * pas);
                transform.Rotate( new Vector3(0, 0.5f, 0) );
                break;
            case "RotG":
                //transform.Rotate(Vector3.up * pas);
                transform.Rotate( new Vector3(0, -0.5f, 0) );
                break;
            case "Kick":
                //transform.Rotate(Vector3.right * 2.5f);
                transform.Rotate( new Vector3(0.7f, 0, 0) );
                break;
            case "Fire":
               // transform.Translate(0, 0, -(transform.position.z));
                break;
            case "NOP":
                break;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = originalPos;
        }


        if (order != null) Debug.Log(order);
        // Reset order
        order = null;
    }

}
