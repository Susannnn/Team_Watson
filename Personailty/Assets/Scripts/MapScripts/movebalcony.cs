﻿using UnityEngine;
using System.Collections;

public class movebalcony : MonoBehaviour {

    //load balcony scene

    void OnMouseDown()
    {

        GameObject.FindWithTag("map").transform.position = new Vector3(-91, 191, -1);
        GameObject.FindWithTag("gamemanager").GetComponent<gameManager>().load_lakehousebalcony();
    }


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
