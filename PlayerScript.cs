using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerScript {

    public class PlayerScript : MonoBehaviour {

        public int poder = 0;
        public static int energy = 0;
        public static int money = 4;

    // Use this for initialization
        void Start () {
         GameController.AumentoPoder += AumentarPoder;
         GameController.ReduccionPoder += ReducirPoder;
        }

        private void AumentarPoder()
        {
         poder++;
            Debug.Log(poder);
        }   

        private void ReducirPoder()
        {
         poder--;
         Debug.Log(poder);
     }

        public void buyEnergy() {
         energy++;
         money--;
         if(money < 0 )
         money = 0;
         Debug.Log("Energia" + energy);
         Debug.Log("Dinero" + money);
     }
        // Update is called once per frame
        void Update () {
		
	    }
    }
}
