﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NPC : MonoBehaviour {

    public Sprite look;    //sprite used for picture

    public string Name;
   
    public bool is_muderer = false;
    public bool is_accused = false;
    public bool is_victim = false;

    public bool first_interaction = true;

    public string clue;

    public string intro;


    public void respond()
    {
       
    }

    // clue 

        public void isMurder()
    {
        is_muderer = true;
    }

    public void is_Victim()
    {
        is_victim = true;
    }

    void Awake() // will not destroy the player on each new scene 
    {
        DontDestroyOnLoad(transform.gameObject);
    }





    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
