using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameController.CambioLuz += CambiarLuz;
    }

    private void CambiarLuz()
    {
        Light myLight = GetComponent<Light>();
        myLight.enabled = !myLight.enabled;
    }
}
