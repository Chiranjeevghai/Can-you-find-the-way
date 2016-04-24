using UnityEngine;
using System.Collections;

public class levelsscreen : MonoBehaviour {
		
	public GUISkin locked;
	public GUISkin Unlocked;


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKey(KeyCode.Escape))
		   {
			Application.LoadLevel(1);
		}
	}

	void OnGUI()
	{
				GUI.skin = Unlocked;
				if (GUI.Button (new Rect (100, 20, 250,250 ), "1")) {
		
			          PlayerPrefs.SetInt("loadlevel",4);	
			          Application.LoadLevel (3);
				}
		        

		if (PlayerPrefs.GetInt ("level1") == 1) {
						if (GUI.Button (new Rect (Screen.width/2-125, 20, 250, 250), "2")) {
								PlayerPrefs.SetInt ("loadlevel", 6);	
								Application.LoadLevel (3);
						}

		}  else {GUI.skin=locked;
			if (GUI.Button (new Rect (Screen.width/2-125,20,250,250), "2")) 
			{
			}}
			GUI.skin = Unlocked;
			if (PlayerPrefs.GetInt ("level2") == 1) {
				if (GUI.Button (new Rect (Screen.width-350, 20, 250, 250), "3")) {
					PlayerPrefs.SetInt ("loadlevel", 8);	
					Application.LoadLevel (3);
				}
				
			}  else {GUI.skin=locked;
				if (GUI.Button (new Rect (Screen.width-350,20,250,250), "3")) 
				{
				}		}
				GUI.skin = Unlocked;
				if (PlayerPrefs.GetInt ("level3") == 1) {
						if (GUI.Button (new Rect (100, Screen.height / 2 - 125, 250, 250), "4")) {
								PlayerPrefs.SetInt ("loadlevel", 10);	
								Application.LoadLevel (3);
						}
					
				} else {
						GUI.skin = locked;
						if (GUI.Button (new Rect (100, Screen.height / 2 - 125, 250, 250), "4")) {
						}
				}	


					GUI.skin = Unlocked;
					if (PlayerPrefs.GetInt ("level4") == 1) {
						if (GUI.Button (new Rect (Screen.width/2-125, Screen.height/2-125, 250, 250), "5")) {
							PlayerPrefs.SetInt ("loadlevel", 12);	
							Application.LoadLevel (3);
						}
						
					}  else {GUI.skin=locked;
						if (GUI.Button (new Rect (Screen.width/2-125,Screen.height/2-125,250,250), "5")) 
						{
						}}	
						GUI.skin = Unlocked;
						if (PlayerPrefs.GetInt ("level5") == 1) {
							if (GUI.Button (new Rect (Screen.width-350, Screen.height/2-125, 250, 250), "6")) {
					 			PlayerPrefs.SetInt ("loadlevel", 14);	
								Application.LoadLevel (3);
							}
							
						}  else {GUI.skin=locked;
							if (GUI.Button (new Rect (Screen.width-350,Screen.height/2-125,250,250), "6")) 
							{
							}	
		
					}

		GUI.skin = Unlocked;
		if (PlayerPrefs.GetInt ("level6") == 1) {
			if (GUI.Button (new Rect (100, Screen.height-270, 250, 250), "7")) {
				PlayerPrefs.SetInt ("loadlevel", 16);	
				Application.LoadLevel (3);
			}
			
		}  else {GUI.skin=locked;
			if (GUI.Button (new Rect (100,Screen.height-270,250,250), "7")) 
			{
			}	
			
		}
		
		GUI.skin = Unlocked;
		if (PlayerPrefs.GetInt ("level7") == 1) {
			if (GUI.Button (new Rect (Screen.width/2-125, Screen.height-270, 250, 250), "8")) {
				PlayerPrefs.SetInt ("loadlevel", 18);	
				Application.LoadLevel (3);
			}
			
		}  else {GUI.skin=locked;
			if (GUI.Button (new Rect (Screen.width/2-125,Screen.height-270,250,250), "8")) 
			{
			}	
			
		}
		
		GUI.skin = Unlocked;
		if (PlayerPrefs.GetInt ("level8") == 1) {
			if (GUI.Button (new Rect (Screen.width-350, Screen.height-270, 250, 250), "9")) {
				PlayerPrefs.SetInt ("loadlevel", 20);	
				Application.LoadLevel (3);
			}
			
		}  else {GUI.skin=locked;
			if (GUI.Button (new Rect (Screen.width-350,Screen.height-270,250,250), "9")) 
			{
			}	
			
		}

		
		}

}