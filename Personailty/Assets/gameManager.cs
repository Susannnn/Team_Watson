﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// gameManager is a script that will be atatched to an object called GameManager that should be created on ever scene 
// it wil hold relevant data needed throughout the game through the use of static variables 
// can only be changed through accessors and mutators 

//used to load scences as well 

public class gameManager : MonoBehaviour {

    // PLAYER attributes
    static public string Name;                         // players name 
    static public Personality_player personailty;      // players pesonailty 
    static public Sprite Sprite;                       // players look 

    static public NPC murderer;      // murderer
    static public NPC victim;        // victim 

    static public string crime;    // the crime that took place EG: stabbed, drowned 

    public NPC current_interaction;


    // NPC GAMEOBJECTS AND LOCATIONS
    static public GameObject room11;
    static public GameObject room12;
    static public GameObject room21;
    static public GameObject room31;
    static public GameObject room41;
    static public GameObject room51;  // lakehouse top floor 
    static public GameObject room61;  // outside the Ron Cooke Hub -- the pods with the lake (Drowned victim )
    static public GameObject room71;
    static public GameObject room72;
    static public GameObject room81; // outside the Ron Cooke hub -- bottom of the lakehouse (PUSHED victim)

    // CLUE ROOM LOCATIONS  
	 static public GameObject clue_room1;
    static public GameObject clue_room2;
    static public GameObject clue_room3;
    static public GameObject clue_room4;
    static public GameObject clue_room5;
    static public GameObject clue_room6;
    static public GameObject clue_room7;
    static public GameObject clue_room8;



    // UI elements --> USED IN THE PLAYER SLECTION MENU
    public Button finish_playerSelect;                 // button finish for player select screen 

    public GameObject create_npcs;

    // int to show the number of clues which have been found so far 
    static public int found_clues = 0;

    static bool player_set = false;


    // -------------------------------------------------------------------------------------------------------------------------------------
    
    public void set_player_to_true()
    {
        player_set = true;
    }
    public bool get_player_set()
    {
        return player_set;
    }




    
    // Accessors and mutators for attributes for the player  

    public void loadName(string namein) //FUNCTION TO A CHANGE THE VALUE OF NAME 
    {
        Name = namein;
    }


    public void loadPersonailty(Personality_player personal) //FUNCTION TO CHANGE THE VALUE OF PESONAILTY
    {
        personailty = personal;
    }

    public void loadSprite(Sprite sprite)   // load the sprite
    {
        Sprite = sprite;
    }

    public string getName()    // returns the name 
    {
        return Name;
    }

    public Sprite getSprite()  // returns the sprite
    {
        return Sprite;
    }


    public Personality_player getPersonality() // returns the personailty of the player 
    {
        return personailty;
    }


    // FUNCTIONS TO SET THE MURDERER FOR THE GAME AND THE VICTIM AND THE MURDER 

    public void set_murder(NPC npc)
    {
        murderer = npc;
    }
    public string get_murder()
    {
        return murderer.Name;
    }
    public NPC get_whole_murderer()  // get all atributes of the murder
    {
        return murderer;
    }

    public void set_crime(string crimein)
    {
       crime = crimein;
    }

    public string get_crime()
    {
        return crime;
    }


    public void set_victim(NPC npc)
    {
        victim = npc;
    }
    public string get_victim()
    {
        return victim.Name; ;
    }
    public NPC get_whole_victim()
    {
        return victim;
    }

	//methods for setting the rooms for the clues adn the NPC who they are attached to 
	public void setClue1(GameObject clue){
        clue_room1 = clue;
	}
	public void setClue2(GameObject clue){
        clue_room2 = clue;
	}
	public void setClue3(GameObject clue){
        clue_room3 = clue;
	}
	public void setClue4(GameObject clue){
        clue_room4 = clue;
	}
	public void setClue5(GameObject clue){
        clue_room5 = clue;
	}
	public void setClue6(GameObject clue){
        clue_room6 = clue;
	}
    public void setClue7(GameObject clue)
    {
        clue_room7 = clue;
    }
    public void setClue8(GameObject clue)
    {
        clue_room8 = clue;
    }

    public void setNPCclue(NPC npc, GameObject clue)  // used to set the npc clue 
    {
        npc.clue = clue.GetComponent<clue>().name;
    }

    public void increase_clue_count()
    {
        found_clues++;
    }
    public int get_clue_count()
    {
        return found_clues;
    }
	


    //methods for setting the players in the room in pos

    public void setroom11(GameObject npc)
    {
        room11 = npc;
    }
    public void setroom12(GameObject npc)
    {
        room12 = npc;
    }
    public void setroom21(GameObject npc)
    {
        room21 = npc;
    }
    public void setroom31(GameObject npc)
    {
        room31 = npc;
    }
    public void setroom41(GameObject npc)
    {
        room41 = npc;
    }
    public void setroom51(GameObject npc)
    {
        room51 = npc;
    }
    public void setroom61(GameObject npc)
    {
        room61 = npc;
    }
    public void setroom71(GameObject npc)
    {
        room71 = npc;
    }
    public void setroom72(GameObject npc)
    {
        room72 = npc;
    }
    public void setroom81(GameObject npc)
    {
        room81 = npc;
    }


    public void reset_npc_pos()    // will return all npcs back to starting pos. 
    {
        GameObject.FindWithTag(room11.GetComponent<NPC>().Name).GetComponent<NPC>().reset_pos();
        GameObject.FindWithTag(room12.GetComponent<NPC>().Name).GetComponent<NPC>().reset_pos();
        GameObject.FindWithTag(room21.GetComponent<NPC>().Name).GetComponent<NPC>().reset_pos();
        GameObject.FindWithTag(room31.GetComponent<NPC>().Name).GetComponent<NPC>().reset_pos();
        GameObject.FindWithTag(room41.GetComponent<NPC>().Name).GetComponent<NPC>().reset_pos();
        GameObject.FindWithTag(room51.GetComponent<NPC>().Name).GetComponent<NPC>().reset_pos();
        GameObject.FindWithTag(room61.GetComponent<NPC>().Name).GetComponent<NPC>().reset_pos();
        GameObject.FindWithTag(room71.GetComponent<NPC>().Name).GetComponent<NPC>().reset_pos();
        GameObject.FindWithTag(room72.GetComponent<NPC>().Name).GetComponent<NPC>().reset_pos();
        GameObject.FindWithTag(room81.GetComponent<NPC>().Name).GetComponent<NPC>().reset_pos();
    }

    public void reset_clue_pos()
    {
        GameObject.FindWithTag("Clue1").GetComponent<clue>().reset_pos();
        GameObject.FindWithTag("Clue2").GetComponent<clue>().reset_pos();
        GameObject.FindWithTag("Clue3").GetComponent<clue>().reset_pos();
        GameObject.FindWithTag("Clue4").GetComponent<clue>().reset_pos();
        GameObject.FindWithTag("Clue5").GetComponent<clue>().reset_pos();
        GameObject.FindWithTag("Clue6").GetComponent<clue>().reset_pos();
    }


    public void check_room_clue(GameObject roomclue)
    {
        if(roomclue == null)
        {
            ;
        } else
        {
            GameObject.FindWithTag(roomclue.GetComponent<clue>().cluename).GetComponent<Transform>().Translate(200, 30, 0);
        }
    }



    // FUNCTIONS TO POPULATE THE ROOMS WITH THE NPCS

    public void populateroom1()
    {
       reset_npc_pos();
       reset_clue_pos();
       GameObject.FindWithTag(room11.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(250,0,0);   //each npc has a tag which is their name making them easier to find 
       GameObject.FindWithTag(room12.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(350,0,0);
       check_room_clue(clue_room1);

    }

    public void populateroom2()
    {
        reset_npc_pos();
        reset_clue_pos();
        GameObject.FindWithTag(room21.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(400, 0, 0);
        check_room_clue(clue_room2);
    }

    public void populateroom3()
    {
        reset_npc_pos();
        reset_clue_pos();
        GameObject.FindWithTag(room31.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(400, 0, 0);
        check_room_clue(clue_room3);
    }

    public void populateroom4()
    {
        reset_npc_pos();
        reset_clue_pos();
        GameObject.FindWithTag(room41.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(400, 0, 0);
        check_room_clue(clue_room4);
    }

    public void populateroom5()
    {
        reset_npc_pos();
        reset_clue_pos();
        GameObject.FindWithTag(room51.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(400, 0, 0);
        check_room_clue(clue_room5);
    }

    public void populateroom6()
    {
        reset_npc_pos();
        reset_clue_pos();
        GameObject.FindWithTag(room61.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(400, 0, 0);
        check_room_clue(clue_room6);
    }

    public void populateroom7()
    {
        reset_npc_pos();
        reset_clue_pos();
        GameObject.FindWithTag(room71.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(400, 0, 0);
        GameObject.FindWithTag(room72.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(300, 0, 0);
        check_room_clue(clue_room7);
    }

    public void populateroom8()
    {
        reset_npc_pos();
        reset_clue_pos();
        GameObject.FindWithTag(room81.GetComponent<NPC>().Name).GetComponent<Transform>().Translate(400, 0, 0);
        check_room_clue(clue_room8);
    }

    public void set_player_pos_firsttime()
    {
        GameObject.FindWithTag("Player").GetComponent<Transform>().position = new Vector3(-140, -20, 0);
    }

    public void set_player_vel_0()
    {
        GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
    }

    // FUNCTIONs TO MOVE BETWEEN SCENES 


    public void load_player_select()
    {
        SceneManager.LoadScene("test1");     // load the player selection scene
    }

    public void load_case_file()  // after player select load the case file 
    {
        SceneManager.LoadScene("casefile");
       
    }

    public void place_map_gui()
    {
        GameObject.FindWithTag("map_icon").transform.position = new Vector3(162,84,0);
    }

    public void load_RCH1_from_case()
    {
        SceneManager.LoadScene("Screen2");
        set_player_pos_firsttime();
        place_map_gui();
        populateroom1();
        set_player_vel_0();

    }


    public void load_RCH1()   // load the first RCH
    { // loads room 1 
        SceneManager.LoadScene("Screen2");
        populateroom1();
        set_player_vel_0();

    }

    public void load_RCH2()   // mload the second main hall of rch 
    {  
        SceneManager.LoadScene("Screen3");
        populateroom2();
        set_player_vel_0();
    }

    public void load_meetingroom()  //load the 2nd floor meeting room 
    {
        SceneManager.LoadScene("Room3");
        populateroom3();
        set_player_vel_0();
    }

    public void load_kitchen() // load the kitchen 
    {
        SceneManager.LoadScene("Room4");
        populateroom4();
        set_player_vel_0();
    }

    public void load_lakehousebalcony() // load the lakehouse balcony 
    {
        SceneManager.LoadScene("Room5");
        populateroom5();
        set_player_vel_0();
    }

    public void load_outside_lakes() // loads the pods outside 
    {
        SceneManager.LoadScene("Room6");
        populateroom6();
        set_player_vel_0();
    }

    public void load_upstairslecture() // loads the second floor lecture room 
    {
        SceneManager.LoadScene("Room7");
        populateroom7();
        set_player_vel_0();
    }

    public void load_outside_bottombalcony() // loads the bottom of the balcony 
    {
        SceneManager.LoadScene("Room8");
        populateroom8();
        set_player_vel_0();
    }

    

    // for testing 



    void Start () {
        //Debug.Log("Room1.1 = " + room11);    // so we can see who is in the rooms for testing 
        //Debug.Log("Room1.2 = " + room12);
        //Debug.Log("Room2.1 = " + room21);
        //Debug.Log("Room3.1 = " + room31);
        //Debug.Log("Room4.1 = " + room41);
        //Debug.Log("Room5.1 = " + room51);
        //Debug.Log("Room6.1 = " + room61);
        //Debug.Log("Room7.1 = " + room71);
        //Debug.Log("Room7.2 = " + room72);
       // Debug.Log("Room8.1 = " + room81);

    }
	
	
	void Update () {
	
	}
}
