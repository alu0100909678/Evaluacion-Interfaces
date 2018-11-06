using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public delegate void PlayerEvents();
    public static event PlayerEvents CambioLuz;
    public static event PlayerEvents AumentoPoder;
    public static event PlayerEvents ReduccionPoder;
    public static event PlayerEvents changeColor;

    void Update()
    {   if (Input.GetKeyDown(KeyCode.L))
        {
            CambioLuz();
        }  

        if(Input.GetKeyDown(KeyCode.F)) {
            changeColor();
        }   

        if(Input.GetKeyDown(KeyCode.G)) {
            AumentoPoder();
        }      
    }

    public static void AumentarPoder()
    {
        if (AumentoPoder != null)
        {
            AumentoPoder();
        }
    }

    public static void ReducirPoder()
    {
        if (ReduccionPoder != null)
        {
            ReduccionPoder();
        }
    }
}
