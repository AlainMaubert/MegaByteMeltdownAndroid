﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireWallController : MonoBehaviour {
	public float speed;
    public bool paused;
	// Use this for initialization
	void Start () {
        paused = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
        }

        if (paused)
        {
            //do nothing
        }
        else if (!paused)
        {
			transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
}
