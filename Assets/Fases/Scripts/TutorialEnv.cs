﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialEnv : MonoBehaviour {



    // Use this for initialization
    void Start () {
		
    }
	

	// Update is called once per frame
	void Update () {

        while (Input.GetKeyDown(KeyCode.DownArrow)){
            transform.Translate(0, 1, 0);
        }
	}
}
