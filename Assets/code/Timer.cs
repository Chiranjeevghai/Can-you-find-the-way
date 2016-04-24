using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	public float leveltime;
	public int level;
	//private float starttime;
	private float timeremaining=0f;
	public GUISkin time;
	//private float prevoustime;
	// Use this for initialization
	void Start () {
		Screen.sleepTimeout = SleepTimeout.NeverSleep; 
		leveltime = leveltime +Time.time;
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){	


		GUI.skin = time;
				if (timeremaining < 0) {
						Application.LoadLevel (level);
				} 
		else
		
		{
			timeremaining = leveltime - Time.time;
			
			
			GUI.Button (new Rect (10, 10, 150, 70), timeremaining.ToString ("0"));
		}
						
		}
}
