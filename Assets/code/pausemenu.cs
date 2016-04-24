using UnityEngine;
using System.Collections;

public class pausemenu : MonoBehaviour {
	private bool pause=false;
	//private bool toggle=true;
	public GameObject hero;
	private accelerometerinput Accelerometerinput;
	public GUISkin time1;
	//public int scene;
	//public int scene2;
	//private int cnt=0;
	// Use this for initialization
	void Start () {
		Accelerometerinput = hero.GetComponent<accelerometerinput> ();
	}
	
	// Update is called once per frame
	void Update () {
	  if(Input.GetKey(KeyCode.Escape))
		{  

			Time.timeScale=0.0f;
			Accelerometerinput.enabled=false;
			pause=true;
			}
		}

	void OnGUI()
	{if(pause)
		{   //RenderSettings.fogColor = Color.blue;

			GUI.skin = time1;
			//RenderSettings.fog = true;

			RenderSettings.fog = true;
			if(GUI.Button (new Rect((Screen.width)/2-100,Screen.height/2+100,200,100), "Quit"))
			{   	Accelerometerinput.enabled=!Accelerometerinput.enabled;
				RenderSettings.fog = false;
			
				PlayerPrefs.SetInt("loadlevel",1);
				Application.LoadLevel(3);
				Time.timeScale = 1.0f;
			}
			if(GUI.Button (new Rect((Screen.width)/2,Screen.height/2-50,200,100), "Restart"))
			{RenderSettings.fog = false;
				Accelerometerinput.enabled=!Accelerometerinput.enabled;
				//print("Restart");
				Application.LoadLevel(3);
			Time.timeScale = 1.0f;
				pause= false;
			}
			if(GUI.Button (new Rect((Screen.width)/2-100,Screen.height/2-200, 200,100), "Continue"))
			{	RenderSettings.fog = false;
				Accelerometerinput.enabled=!Accelerometerinput.enabled;
				//print("Continue");
				Time.timeScale = 1.0f;
				pause = false;   
			}
		
}

}
     
}