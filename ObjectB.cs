using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerScript;

public class ObjectB : MonoBehaviour {

    // Use this for initialization
    void Start()
    {   
        
        GameController.ReduccionPoder += ReducirPoder;
        GameController.changeColor += changeColor;
        GameController.AumentoPoder += ReducirPoder;
    }

    private void ReducirPoder()
    {
        transform.localScale += new Vector3(0, 0.5F, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        GameController.ReducirPoder();
    }

    private void changeColor() {

        Renderer rend = GetComponent<Renderer>();
        PlayerScript.PlayerScript.money--;
        Debug.Log("Dinero " + PlayerScript.PlayerScript.money);
        //Debug.Log(PlayerScript.PlayerScript.energy);
        switch(PlayerScript.PlayerScript.energy) {
            case 1: 
            //rend.material.shader = Shader.Find("_Color");
            rend.material.SetColor("_Color", Color.green);
            break;
            case 2: 
            //rend.material.shader = Shader.Find("_Color");
            rend.material.SetColor("_Color", Color.red);
            break; 
            case 3: 
            //rend.material.shader = Shader.Find("_Color");
            rend.material.SetColor("_Color", Color.blue);
            break; 
            case 4: 
            //rend.material.shader = Shader.Find("_Color");
            rend.material.SetColor("_Color", Color.white);
            break;
        }
    }
}
