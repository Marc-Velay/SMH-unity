using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpaceBar : MonoBehaviour
{

    bool available;
    string data;


    // Use this for initialization
    void Start()
    {
        Debug.Log("I am alive!");
        available = true;
        data = null;
        return;

    }

    // Récupérer une frame et l'envoyer à send.cs
    void Update()
    {
        if (available)
        {
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
               for (int a = 0; a < 60; a++)
                {
                    // Récupérer les données du leap format JSON

                    // Append



                }
               


                available = true;
                
            }


        }
    }

}
        


